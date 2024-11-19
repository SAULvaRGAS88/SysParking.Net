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
    public class TabalaPrecoesController : Controller
    {
        private readonly SysParkingNetContext _context;

        public TabalaPrecoesController(SysParkingNetContext context)
        {
            _context = context;
        }

        // GET: TabalaPrecoes
        public async Task<IActionResult> Index()
        {
            var sysParkingNetContext = _context.TabalaPreco.Include(t => t.Estacionamento);
            return View(await sysParkingNetContext.ToListAsync());
        }

        // GET: TabalaPrecoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TabalaPreco == null)
            {
                return NotFound();
            }

            var tabalaPreco = await _context.TabalaPreco
                .Include(t => t.Estacionamento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tabalaPreco == null)
            {
                return NotFound();
            }

            return View(tabalaPreco);
        }

        // GET: TabalaPrecoes/Create
        public IActionResult Create()
        {
            ViewData["EstacionamentoId"] = new SelectList(_context.Estacionamento, "Id", "Id");
            return View();
        }

        // POST: TabalaPrecoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Preco15Min,Preco30Min,Preco1Hora,PrecoDiaria,PrecoMensal,EstacionamentoId")] TabalaPreco tabalaPreco)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tabalaPreco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EstacionamentoId"] = new SelectList(_context.Estacionamento, "Id", "Id", tabalaPreco.EstacionamentoId);
            return View(tabalaPreco);
        }

        // GET: TabalaPrecoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TabalaPreco == null)
            {
                return NotFound();
            }

            var tabalaPreco = await _context.TabalaPreco.FindAsync(id);
            if (tabalaPreco == null)
            {
                return NotFound();
            }
            ViewData["EstacionamentoId"] = new SelectList(_context.Estacionamento, "Id", "Id", tabalaPreco.EstacionamentoId);
            return View(tabalaPreco);
        }

        // POST: TabalaPrecoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Preco15Min,Preco30Min,Preco1Hora,PrecoDiaria,PrecoMensal,EstacionamentoId")] TabalaPreco tabalaPreco)
        {
            if (id != tabalaPreco.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tabalaPreco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabalaPrecoExists(tabalaPreco.Id))
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
            ViewData["EstacionamentoId"] = new SelectList(_context.Estacionamento, "Id", "Id", tabalaPreco.EstacionamentoId);
            return View(tabalaPreco);
        }

        // GET: TabalaPrecoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TabalaPreco == null)
            {
                return NotFound();
            }

            var tabalaPreco = await _context.TabalaPreco
                .Include(t => t.Estacionamento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tabalaPreco == null)
            {
                return NotFound();
            }

            return View(tabalaPreco);
        }

        // POST: TabalaPrecoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TabalaPreco == null)
            {
                return Problem("Entity set 'SysParkingNetContext.TabalaPreco'  is null.");
            }
            var tabalaPreco = await _context.TabalaPreco.FindAsync(id);
            if (tabalaPreco != null)
            {
                _context.TabalaPreco.Remove(tabalaPreco);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabalaPrecoExists(int id)
        {
          return (_context.TabalaPreco?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
