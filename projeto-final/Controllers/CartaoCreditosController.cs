#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using projeto_final.Models;

namespace projeto_final.Controllers
{
    public class CartaoCreditosController : Controller
    {
        private readonly MyDbContext _context;

        public CartaoCreditosController(MyDbContext context)
        {
            _context = context;
        }

        // GET: CartaoCreditos
        public async Task<IActionResult> Index()
        {
            return View(await _context.CartaoCreditos.ToListAsync());
        }

        // GET: CartaoCreditos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartaoCredito = await _context.CartaoCreditos
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cartaoCredito == null)
            {
                return NotFound();
            }

            return View(cartaoCredito);
        }

        // GET: CartaoCreditos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CartaoCreditos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NumeroCartao,ID,ValorPedido,Faturado")] CartaoCredito cartaoCredito)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cartaoCredito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cartaoCredito);
        }

        // GET: CartaoCreditos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartaoCredito = await _context.CartaoCreditos.FindAsync(id);
            if (cartaoCredito == null)
            {
                return NotFound();
            }
            return View(cartaoCredito);
        }

        // POST: CartaoCreditos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NumeroCartao,ID,ValorPedido,Faturado")] CartaoCredito cartaoCredito)
        {
            if (id != cartaoCredito.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartaoCredito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartaoCreditoExists(cartaoCredito.ID))
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
            return View(cartaoCredito);
        }

        // GET: CartaoCreditos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartaoCredito = await _context.CartaoCreditos
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cartaoCredito == null)
            {
                return NotFound();
            }

            return View(cartaoCredito);
        }

        // POST: CartaoCreditos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cartaoCredito = await _context.CartaoCreditos.FindAsync(id);
            _context.CartaoCreditos.Remove(cartaoCredito);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartaoCreditoExists(int id)
        {
            return _context.CartaoCreditos.Any(e => e.ID == id);
        }
    }
}
