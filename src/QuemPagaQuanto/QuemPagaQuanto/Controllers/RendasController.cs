using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuemPagaQuanto.Models;

namespace QuemPagaQuanto.Controllers
{
    public class RendasController: Controller
    {
        private readonly AppDbContext _context;
        public RendasController(AppDbContext context)
        {
            _context = context;

        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Rendas.Include(r => r.Morador).ToListAsync();

            return View(dados);
        }

        public IActionResult Create()
        {
            ViewData["Moradores"] = new SelectList(_context.Moradores, "Id", "Nome");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Renda renda)
        {
            if(ModelState.IsValid) 
            {
                _context.Rendas.Add(renda);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewData["Moradores"] = new SelectList(_context.Moradores, "Id", "Nome", renda.MoradorId);
            return View(renda);

        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Rendas.FindAsync(id);

            if(dados == null)
                return NotFound();

            ViewData["Moradores"] = new SelectList(_context.Moradores, "Id", "Nome", dados.MoradorId);
            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, Renda renda)
        {
            if (id != renda.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Rendas.Update(renda);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewData["Moradores"] = new SelectList(_context.Moradores, "Id", "Nome", renda.MoradorId);
            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
                return NotFound();  

            var dados = await _context.Rendas.FindAsync(id);
            
            if(dados == null)
                return NotFound();  

            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Rendas.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Rendas.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Rendas.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}
