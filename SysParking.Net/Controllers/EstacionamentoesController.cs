using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SysParking.Net.Data;
using SysParking.Net.Models;

namespace SysParking.Net.Controllers
{
    public class EstacionamentoesController : Controller
    {
        private readonly SysParkingNetContext _context;

        public EstacionamentoesController(SysParkingNetContext context)
        {
            _context = context;
        }

        // GET: Estacionamentoes
        public async Task<IActionResult> Index()
        {
            var sysParkingNetContext = _context.Estacionamento.Include(e => e.Gestor);
            return View(await sysParkingNetContext.ToListAsync());
        }

        // GET: Estacionamentoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Estacionamento == null)
            {
                return NotFound();
            }

            var estacionamento = await _context.Estacionamento
                .Include(e => e.Gestor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estacionamento == null)
            {
                return NotFound();
            }

            return View(estacionamento);
        }

        // GET: Estacionamentoes/Create
        public IActionResult Create()
        {
            ViewData["GestorId"] = new SelectList(_context.Set<Gestor>(), "Id", "Id");
            return View();
        }

        // POST: Estacionamentoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Endereco,NumeroVagasDisponiveis,GestorId")] Estacionamento estacionamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estacionamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GestorId"] = new SelectList(_context.Set<Gestor>(), "Id", "Id", estacionamento.GestorId);
            return View(estacionamento);
        }

        // GET: Estacionamentoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Estacionamento == null)
            {
                return NotFound();
            }

            var estacionamento = await _context.Estacionamento.FindAsync(id);
            if (estacionamento == null)
            {
                return NotFound();
            }
            ViewData["GestorId"] = new SelectList(_context.Set<Gestor>(), "Id", "Id", estacionamento.GestorId);
            return View(estacionamento);
        }

        // POST: Estacionamentoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Endereco,NumeroVagasDisponiveis,GestorId")] Estacionamento estacionamento)
        {
            if (id != estacionamento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estacionamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstacionamentoExists(estacionamento.Id))
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
            ViewData["GestorId"] = new SelectList(_context.Set<Gestor>(), "Id", "Id", estacionamento.GestorId);
            return View(estacionamento);
        }

        // GET: Estacionamentoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Estacionamento == null)
            {
                return NotFound();
            }

            var estacionamento = await _context.Estacionamento
                .Include(e => e.Gestor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estacionamento == null)
            {
                return NotFound();
            }

            return View(estacionamento);
        }

        // POST: Estacionamentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Estacionamento == null)
            {
                return Problem("Entity set 'SysParkingNetContext.Estacionamento'  is null.");
            }
            var estacionamento = await _context.Estacionamento.FindAsync(id);
            if (estacionamento != null)
            {
                _context.Estacionamento.Remove(estacionamento);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstacionamentoExists(int id)
        {
          return (_context.Estacionamento?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
