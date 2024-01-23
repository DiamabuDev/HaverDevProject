using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HaverDevProject.Data;
using HaverDevProject.Models;

namespace HaverDevProject.Controllers
{
    public class SupplierController : Controller
    {
        private readonly HaverNiagaraContext _context;

        public SupplierController(HaverNiagaraContext context)
        {
            _context = context;
        }

        // GET: Supplier
        public async Task<IActionResult> Index(string actionButton, string sortDirection = "asc", string sortField = "Code")
        {
            //List of sort options.
            string[] sortOptions = new[] { "Code", "Name", "Email"};

            var suppliers = _context.Suppliers
                .AsNoTracking();

            if (!String.IsNullOrEmpty(actionButton)) //Form Submitted!
            {
                //page = 1;//Reset page to start /***********deshabilitar cuando se defina el paginado.

                if (sortOptions.Contains(actionButton))//Change of sort is requested
                {
                    if (actionButton == sortField) //Reverse order on same field
                    {
                        sortDirection = sortDirection == "asc" ? "desc" : "asc";
                    }
                    sortField = actionButton;//Sort by the button clicked
                }
            }
            //Now we know which field and direction to sort by
            if (sortField == "Code")
            {
                if (sortDirection == "asc")
                {
                    suppliers = suppliers
                        .OrderBy(p => p.SupplierCode);
                    ViewData["sortDirectionCodeApplied"]="<i class=\"bi bi-sort-down\"></i>";
                }
                else
                {
                    suppliers = suppliers
                        .OrderByDescending(p => p.SupplierCode);
                    ViewData["sortDirectionCodeApplied"]="<i class=\"bi bi-sort-up\"></i>";
                }
            }
            else if (sortField == "Name")
            {
                if (sortDirection == "asc")
                {
                    suppliers = suppliers
                        .OrderBy(p => p.SupplierName);
                    ViewData["sortDirectionNameApplied"] = "<i class=\"bi bi-sort-down\"></i>";
                }
                else
                {
                    suppliers = suppliers
                        .OrderByDescending(p => p.SupplierName);
                    ViewData["sortDirectionNameApplied"] = "<i class=\"bi bi-sort-up\"></i>";
                }
            }            
            else //Sorting by Email
            {
                if (sortDirection == "asc")
                {
                    suppliers = suppliers
                        .OrderBy(p => p.SupplierEmail);
                }
                else
                {
                    suppliers = suppliers
                        .OrderByDescending(p => p.SupplierEmail);
                }
            }
            //Set sort for next time
            ViewData["sortField"] = sortField;
            ViewData["sortDirection"] = sortDirection;

            return View(await suppliers.ToListAsync());

            
        }

        // GET: Supplier/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Suppliers == null)
            {
                return NotFound();
            }

            var supplier = await _context.Suppliers
                .FirstOrDefaultAsync(m => m.SupplierId == id);
            if (supplier == null)
            {
                return NotFound();
            }

            return View(supplier);
        }

        // GET: Supplier/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Supplier/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupplierId,SupplierCode,SupplierName,SupplierEmail")] Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supplier);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(supplier);
        }

        // GET: Supplier/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Suppliers == null)
            {
                return NotFound();
            }

            var supplier = await _context.Suppliers.FindAsync(id);
            if (supplier == null)
            {
                return NotFound();
            }
            return View(supplier);
        }

        // POST: Supplier/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupplierId,SupplierCode,SupplierName,SupplierEmail")] Supplier supplier)
        {
            if (id != supplier.SupplierId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supplier);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupplierExists(supplier.SupplierId))
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
            return View(supplier);
        }

        // GET: Supplier/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Suppliers == null)
            {
                return NotFound();
            }

            var supplier = await _context.Suppliers
                .FirstOrDefaultAsync(m => m.SupplierId == id);
            if (supplier == null)
            {
                return NotFound();
            }

            return View(supplier);
        }

        // POST: Supplier/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Suppliers == null)
            {
                return Problem("Entity set 'HaverNiagaraContext.Suppliers'  is null.");
            }
            var supplier = await _context.Suppliers.FindAsync(id);
            if (supplier != null)
            {
                _context.Suppliers.Remove(supplier);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupplierExists(int id)
        {
          return _context.Suppliers.Any(e => e.SupplierId == id);
        }
    }
}
