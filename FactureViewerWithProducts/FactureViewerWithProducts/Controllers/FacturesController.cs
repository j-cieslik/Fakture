using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FactureViewerWithProducts.Data;
using FactureViewerWithProducts.Models;
using FactureViewerWithProducts.Dtos;

namespace FactureViewerWithProducts.Controllers
{
    public class FacturesController : Controller
    {
        private readonly FactureContext _context;

        public FacturesController(FactureContext context)
        {
            _context = context;
        }

        // GET: Factures
        public async Task<IActionResult> Index([FromQuery] FactureFilterParams factureParams)
        {

						ViewData["CodeSortParam"] = string
									.IsNullOrEmpty(factureParams.sortOrder) 
									? "Code_desc" : "";
						ViewData["DateSortParam"] = factureParams.sortOrder == "Date" 
									? "Date_desc" : "Date";
						ViewData["StatusSortParam"] = factureParams.sortOrder == "Status" 
									? "Status_desc" : "Status";
						ViewData["CitySortParam"] = factureParams.sortOrder == "City" 
									? "City_desc" : "City";

            var factureContext = await _context.Factures
										.Include(c => c.Status)
										.Select(c => c).ToListAsync();

						if(!string.IsNullOrEmpty(factureParams.Code))
						{

							factureContext = factureContext.Where(c => 
									c.Code.ToString()
												.Contains(factureParams.Code))
												.ToList();
						}

						if(!string.IsNullOrEmpty(factureParams.Date))
						{
							factureContext = factureContext.Where(c => 
									c.Date.ToString()
												.Contains(factureParams.Date))
												.ToList();
						}

						if(!string.IsNullOrEmpty(factureParams.Status))
						{
							factureContext = factureContext.Where(c => 
									c.Status.StatusName
													.ToLower()
													.Contains(factureParams.Status
													.ToLower()))
													.ToList();
						}

						if(!string.IsNullOrEmpty(factureParams.City))
						{
							factureContext = factureContext.Where(c => 
									c.City.ToLower()
												.Contains(factureParams.City
												.ToLower()))
												.ToList();
						}

						switch (factureParams.sortOrder)
						{
							case "Code_desc":
									factureContext = factureContext
												.OrderByDescending(c => c.Code)
												.ToList();
									break;
							case "Date":
									factureContext = factureContext
												.OrderBy(c => c.Date)
												.ToList();
									break;
							case "Date_desc":
									factureContext = factureContext
												.OrderByDescending(c => c.Date)
												.ToList();
									break;
							case "Status":
									factureContext = factureContext
												.OrderBy(c => c.Status.StatusName)
												.ToList();
									break;
							case "Status_desc":
									factureContext = factureContext
												.OrderByDescending(c => c.Status.StatusName)
												.ToList();
									break;
							case "City":
									factureContext = factureContext
												.OrderBy(c => c.City)
												.ToList();
									break;
							case "City_desc":
									factureContext = factureContext
												.OrderByDescending(c => c.City)
												.ToList();
									break;
						}

            return View(factureContext);
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
								.Include(f => f.FactureProducts)
								.ThenInclude(f => f.Product)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (facture == null)
            {
                return NotFound();
            }

						var factureDetails = new FactureDetailsDto();

						factureDetails.Id = facture.Id;
						factureDetails.Code = facture.Code;
						factureDetails.Date = facture.Date;
						factureDetails.City = facture.City;
						factureDetails.StatusName = facture.Status.StatusName;
						
						factureDetails.Product = facture.FactureProducts
													.Select(f => f.Product)
													.ToList();

						factureDetails.PriceBrutto = factureDetails.Product
													.Select(f => f.Count * f.Price + f.Count * f.Price * f.Tax)
													.Sum();
						factureDetails.PriceNetto = factureDetails.Product
													.Select(f => f.Count * f.Price)
													.Sum();

            return View(factureDetails);
        }

        // GET: Factures/Create
        public IActionResult Create()
        {
            ViewData["StatusID"] = new SelectList(_context.Statuses, "Id", "StatusName");
            return View();
        }

        // POST: Factures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Code,Date,City,StatusID")] Facture facture)
        {
            if (ModelState.IsValid)
            {
                _context.Add(facture);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StatusID"] = new SelectList(_context.Statuses, "Id", "StatusName", facture.StatusID);
            return View(facture);
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
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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
            _context.Factures.Remove(facture);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FactureExists(int id)
        {
            return _context.Factures.Any(e => e.Id == id);
        }
    }
}
