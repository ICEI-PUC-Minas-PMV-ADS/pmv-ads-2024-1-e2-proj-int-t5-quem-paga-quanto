using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuemPagaQuanto.Models;

namespace QuemPagaQuanto.Controllers
{
    [Authorize]
    public class MoradoresController : Controller
    {
        private readonly AppDbContext _context;

        public MoradoresController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Moradores
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Moradores.Include(m => m.Grupo);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Moradores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Moradores == null)
            {
                return NotFound();
            }

            var morador = await _context.Moradores
                .Include(m => m.Grupo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (morador == null)
            {
                return NotFound();
            }

            return View(morador);
        }

        // GET: Moradores/Create
        public IActionResult Create()
        {
            ViewData["GrupoId"] = new SelectList(_context.Grupos, "Id", "Nome");
            return View();
        }

        // POST: Moradores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Email,GrupoId")] Morador morador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(morador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GrupoId"] = new SelectList(_context.Grupos, "Id", "Nome", morador.GrupoId);
            return View(morador);
        }

        // GET: Moradores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Moradores == null)
            {
                return NotFound();
            }

            var morador = await _context.Moradores.FindAsync(id);
            if (morador == null)
            {
                return NotFound();
            }
            ViewData["GrupoId"] = new SelectList(_context.Grupos, "Id", "Nome", morador.GrupoId);
            return View(morador);
        }

        // POST: Moradores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Email,GrupoId")] Morador morador)
        {
            if (id != morador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(morador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoradorExists(morador.Id))
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
            ViewData["GrupoId"] = new SelectList(_context.Grupos, "Id", "Nome", morador.GrupoId);
            return View(morador);
        }

        // GET: Moradores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Moradores == null)
            {
                return NotFound();
            }

            var morador = await _context.Moradores
                .Include(m => m.Grupo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (morador == null)
            {
                return NotFound();
            }

            return View(morador);
        }

        // POST: Moradores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Moradores == null)
            {
                return Problem("Entity set 'AppDbContext.Moradores'  is null.");
            }
            var morador = await _context.Moradores.FindAsync(id);
            if (morador != null)
            {
                _context.Moradores.Remove(morador);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoradorExists(int id)
        {
          return _context.Moradores.Any(e => e.Id == id);
        }
    }
}
