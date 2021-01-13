using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FactureViewerWithProducts.Data;
using FactureViewerWithProducts.Models;

namespace FactureViewerWithProducts.Controllers
{
    public class FactureProductsController : Controller
    {
        private readonly FactureContext _context;

        public FactureProductsController(FactureContext context)
        {
            _context = context;
        }

        // GET: FactureProducts
        public async Task<IActionResult> Index()
        {
            var factureContext = _context.FactureProducts.Include(f => f.Facture).Include(f => f.Product);
            return View(await factureContext.ToListAsync());
        }

        // GET: FactureProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factureProducts = await _context.FactureProducts
                .Include(f => f.Facture)
                .Include(f => f.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (factureProducts == null)
            {
                return NotFound();
            }

            return View(factureProducts);
        }

        // GET: FactureProducts/Create
        public IActionResult Create(int id)
        {

						var facturePr = new FactureProducts();
						facturePr.FactureId = id;

            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "WareName");
            return View(facturePr);
        }

        // POST: FactureProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FactureId,ProductId")] FactureProducts factureProducts)
        {
            if (ModelState.IsValid)
            {
                _context.Add(factureProducts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FactureId"] = new SelectList(_context.Factures, "Id", "Id", factureProducts.FactureId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", factureProducts.ProductId);
            return View(factureProducts);
        }

        // GET: FactureProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factureProducts = await _context.FactureProducts.FindAsync(id);
            if (factureProducts == null)
            {
                return NotFound();
            }
            ViewData["FactureId"] = new SelectList(_context.Factures, "Id", "Id", factureProducts.FactureId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", factureProducts.ProductId);
            return View(factureProducts);
        }

        // POST: FactureProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FactureId,ProductId")] FactureProducts factureProducts)
        {
            if (id != factureProducts.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(factureProducts);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FactureProductsExists(factureProducts.Id))
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
            ViewData["FactureId"] = new SelectList(_context.Factures, "Id", "Id", factureProducts.FactureId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", factureProducts.ProductId);
            return View(factureProducts);
        }

        // GET: FactureProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factureProducts = await _context.FactureProducts
                .Include(f => f.Facture)
                .Include(f => f.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (factureProducts == null)
            {
                return NotFound();
            }

            return View(factureProducts);
        }

        // POST: FactureProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var factureProducts = await _context.FactureProducts.FindAsync(id);
            _context.FactureProducts.Remove(factureProducts);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FactureProductsExists(int id)
        {
            return _context.FactureProducts.Any(e => e.Id == id);
        }
    }
}
