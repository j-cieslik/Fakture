using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FactureViewer.Data;
using FactureViewer.Models;
using FactureViewer.ViewModel;

namespace FactureViewer.Controllers
{
    public class FacturesController : Controller
    {
        private readonly FactureContext _context;

        public FacturesController(FactureContext context)
        {
            _context = context;
        }

        // GET: Factures
        public async Task<IActionResult> Index()
        {
            var factureContext = _context.Factures
													.Include(f => f.Status)
													.Include(f => f.Product);
            return View(await factureContext.ToListAsync());
        }

        // GET: Factures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facture = await _context.Factures
                .Include(f => f.Status)
								.Include(f => f.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (facture == null)
            {
                return NotFound();
            }

            return View(facture);
        }

        // GET: Factures/Create
        public IActionResult Create()
        {
            ViewData["StatusID"] = new SelectList(_context.Statuses, "Id", "StatusName");
            return View();
        }

        // GET: Factures/CreateFacture
				public IActionResult CreateFacture()
        {
            ViewData["StatusID"] = new SelectList(_context.Statuses, "Id", "StatusName");
            return View();
        }

        // POST: Factures/CreateFacture
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateFacture(FactureViewModel modelView)
        {
            if (ModelState.IsValid)
            {
                var facture = new Facture();

								facture.Code = modelView.Code;
								facture.Date = modelView.Date;
								facture.City = modelView.City;
								facture.StatusID = modelView.StatusID;
								
								_context.Factures.Add(facture);
								_context.SaveChanges();

								var product = new Product();

								product.Price = modelView.Price;
								product.Count = modelView.Count;
								product.Tax = modelView.Tax;
								product.WareName = modelView.WareName;
								product.Id = facture.Id;

								_context.Products.Add(product);
								_context.SaveChanges();

								return RedirectToAction("Index");
								
            }
            ViewData["StatusID"] = new SelectList(_context.Statuses, "Id", "StatusName", modelView.StatusID);
            return View();
        }

        // GET: Factures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facture = await _context.Factures.FindAsync(id);
            if (facture == null)
            {
                return NotFound();
            }
            ViewData["StatusID"] = new SelectList(_context.Statuses, "Id", "Id", facture.StatusID);
            return View(facture);
        }

        // POST: Factures/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Code,Date,City,StatusID")] Facture facture)
        {
            if (id != facture.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(facture);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FactureExists(facture.Id))
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
            ViewData["StatusID"] = new SelectList(_context.Statuses, "Id", "Id", facture.StatusID);
            return View(facture);
        }

        // GET: Factures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facture = await _context.Factures
                .Include(f => f.Status)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (facture == null)
            {
                return NotFound();
            }

            return View(facture);
        }

        // POST: Factures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var facture = await _context.Factures.FindAsync(id);
						var product = await _context.Products.FindAsync(id);
            _context.Factures.Remove(facture);
						_context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FactureExists(int id)
        {
            return _context.Factures.Any(e => e.Id == id);
        }
    }
}
