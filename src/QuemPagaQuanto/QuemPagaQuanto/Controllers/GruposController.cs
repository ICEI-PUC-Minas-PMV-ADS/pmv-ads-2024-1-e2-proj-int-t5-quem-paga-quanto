using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuemPagaQuanto.Database;
using QuemPagaQuanto.Models;
using QuemPagaQuanto.Services;
using System.Security.Claims;

namespace QuemPagaQuanto.Controllers
{
    [Authorize]
    public class GruposController : Controller
    {
        private readonly AppDbContext _context;

        public GruposController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Grupos
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Grupos.Include(g => g.Usuario);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Grupos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Grupos == null)
            {
                return NotFound();
            }

            var grupo = await _context.Grupos
                .Include(g => g.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grupo == null)
            {
                return NotFound();
            }

            return View(grupo);
        }

        // GET: Grupos/Create
        public IActionResult Create()
        {
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email");
            return View();
        }

        // POST: Grupos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] Grupo grupo, List<Claim> claims)
        {
            grupo.UsuarioId = AuthorizeService.GetUserId(User);

            if (ModelState.IsValid)
            {
                _context.Add(grupo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", grupo.UsuarioId);
            return View(grupo);
        }

        // GET: Grupos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Grupos == null)
            {
                return NotFound();
            }

            var grupo = await _context.Grupos.FindAsync(id);
            if (grupo == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", grupo.UsuarioId);
            return View(grupo);
        }

        // POST: Grupos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] Grupo grupo)
        {
            grupo.UsuarioId = AuthorizeService.GetUserId(User);

            if (id != grupo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(grupo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GrupoExists(grupo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", grupo.UsuarioId);
            return View(grupo);
        }

        // GET: Grupos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Grupos == null)
            {
                return NotFound();
            }

            var grupo = await _context.Grupos
                .Include(g => g.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grupo == null)
            {
                return NotFound();
            }

            return View(grupo);
        }

        // POST: Grupos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Grupos == null)
            {
                return Problem("Entity set 'AppDbContext.Grupos'  is null.");
            }
            var grupo = await _context.Grupos.FindAsync(id);
            if (grupo != null)
            {
                _context.Grupos.Remove(grupo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GrupoExists(int id)
        {
            return _context.Grupos.Any(e => e.Id == id);
        }

        public async Task<ActionResult> Relatorio(int id, int? mes, int? ano)
        {
            var hoje = DateTime.Now;

            if (mes == null) mes = hoje.Month;
            if (ano == null) ano = hoje.Year;
            
            var service = new CalcularDespesasService(_context);
            var resultado = service.CalcularProporcional(id, mes, ano);

            var grupo = await _context.Grupos.FindAsync(id);

            if (grupo == null)
            {
                return NotFound();
            }
            
            var total = resultado.Despesas.Sum(c => c.Valor);

            ViewBag.Despesas = resultado.Despesas;
            ViewBag.Total = total;
            ViewBag.Nome = grupo.Nome;
            ViewBag.GrupoId = id;
            ViewBag.Mes = mes;
            ViewBag.Ano = ano;

            return View(new Relatorio() { Despesas = resultado.Despesas, Calculo = resultado });
        }
    }
}
