using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HaverDevProject.Data;
using HaverDevProject.Models;
using HaverDevProject.Utilities;
using HaverDevProject.CustomControllers;
using Microsoft.EntityFrameworkCore.Storage;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HaverDevProject.Controllers
{
    public class SupplierController : ElephantController
    {
        private readonly HaverNiagaraContext _context;

        public SupplierController(HaverNiagaraContext context)
        {
            _context = context;
        }

        // GET: Supplier
        public async Task<IActionResult> Index(string SearchCode, int? page, int? pageSizeID, 
            string actionButton, string sortDirection = "asc", string sortField = "Code")
        {
            //List of sort options.
            string[] sortOptions = new[] { "Code", "Name", "Email"};            

            var suppliers = _context.Suppliers
                .AsNoTracking();

            //Filterig values                       
            if (!String.IsNullOrEmpty(SearchCode))
            {
                suppliers = suppliers.Where(s => s.SupplierCode.ToUpper().Contains(SearchCode.ToUpper())
                                        || s.SupplierName.ToUpper().Contains(SearchCode.ToUpper()));
            }           

            //Sorting columns
            if (!String.IsNullOrEmpty(actionButton)) //Form Submitted!
            {
                page = 1;//Reset page to start

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
                }
                else
                {
                    suppliers = suppliers
                        .OrderByDescending(p => p.SupplierCode);
                }
            }
            else if (sortField == "Name")
            {
                if (sortDirection == "asc")
                {
                    suppliers = suppliers
                        .OrderBy(p => p.SupplierName);
                }
                else
                {
                    suppliers = suppliers
                        .OrderByDescending(p => p.SupplierName);
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

            //return View(await suppliers.ToListAsync());

            int pageSize = PageSizeHelper.SetPageSize(HttpContext, pageSizeID, ControllerName());
            ViewData["pageSizeID"] = PageSizeHelper.PageSizeList(pageSize);
            var pagedData = await PaginatedList<Supplier>.CreateAsync(suppliers.AsNoTracking(), page ?? 1, pageSize);

            return View(pagedData);


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
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(supplier);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (RetryLimitExceededException /* dex */)
            {
                ModelState.AddModelError("", "Unable to save changes after multiple attempts. Try again, and if the problem persists, see your system administrator.");
            }
            catch (DbUpdateException dex)
            {
                if (dex.GetBaseException().Message.Contains("UNIQUE"))
                {
                    ModelState.AddModelError("SupplierCode", "Unable to save changes. Remember, you cannot have duplicate Supplier Code.");
                }
                else
                {
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
                }
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
                return Problem("There are no Suppliers to delete");
            }
            var supplier = await _context.Suppliers.FindAsync(id);

            try
            {
                if (supplier != null)
                {
                    _context.Suppliers.Remove(supplier);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException dex)
            {
                if (dex.GetBaseException().Message.Contains("FOREIGN KEY constraint failed"))
                {
                    ModelState.AddModelError("", "Unable to Delete Supplier. Remember, you cannot delete a Supplier that has a NCR in the system.");
                }
                else
                {
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
                }
            }
            return View(supplier);            
        }

        private bool SupplierExists(int id)
        {
          return _context.Suppliers.Any(e => e.SupplierId == id);
        }
    }
}
