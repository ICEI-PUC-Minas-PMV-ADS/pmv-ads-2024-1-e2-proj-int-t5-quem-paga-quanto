using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuemPagaQuanto.Models;

namespace QuemPagaQuanto.Controllers
{
    [Authorize]
    public class DespesasController : Controller
    {
        private readonly AppDbContext _context;

        public DespesasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Despesas
        public async Task<IActionResult> Index()
        {
              return View(await _context.Despesas.ToListAsync());
        }

        // GET: Despesas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Despesas == null)
            {
                return NotFound();
            }

            var despesa = await _context.Despesas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (despesa == null)
            {
                return NotFound();
            }

            return View(despesa);
        }

        // GET: Despesas/Create
        public IActionResult Create()
        {
            ViewData["GrupoId"] = new SelectList(_context.Grupos, "Id", "Nome");
            return View();
        }

        // POST: Despesas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Data,Vencimento,Valor,Descricao,GrupoId")] Despesa despesa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(despesa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["GrupoId"] = new SelectList(_context.Grupos, "Id", "Nome", despesa.GrupoId);
            return View(despesa);
        }

        // GET: Despesas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Despesas == null)
            {
                return NotFound();
            }

            var despesa = await _context.Despesas.FindAsync(id);
            if (despesa == null)
            {
                return NotFound();
            }

            ViewData["GrupoId"] = new SelectList(_context.Grupos, "Id", "Nome", despesa.GrupoId);
            return View(despesa);
        }

        // POST: Despesas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Data,Vencimento,Valor,Descricao,GrupoId")] Despesa despesa)
        {
            if (id != despesa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(despesa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DespesaExists(despesa.Id))
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

            ViewData["GrupoId"] = new SelectList(_context.Grupos, "Id", "Nome", despesa.GrupoId);
            return View(despesa);
        }

        // GET: Despesas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Despesas == null)
            {
                return NotFound();
            }

            var despesa = await _context.Despesas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (despesa == null)
            {
                return NotFound();
            }

            return View(despesa);
        }

        // POST: Despesas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Despesas == null)
            {
                return Problem("Entity set 'AppDbContext.Despesas'  is null.");
            }
            var despesa = await _context.Despesas.FindAsync(id);
            if (despesa != null)
            {
                _context.Despesas.Remove(despesa);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DespesaExists(int id)
        {
          return _context.Despesas.Any(e => e.Id == id);
        }
    }
}
