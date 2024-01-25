using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HaverDevProject.Data;
using HaverDevProject.Models;
using HaverDevProject.CustomControllers;
using HaverDevProject.Utilities;

namespace HaverDevProject.Controllers
{
    public class ItemController : ElephantController
    {
        private readonly HaverNiagaraContext _context;

        public ItemController(HaverNiagaraContext context)
        {
            _context = context;
        }

        private SelectList SupplierSelectList(int? selectedId)
        {
            return new SelectList(_context.Suppliers.OrderBy(s => s.SupplierName), "SupplierId", "SupplierName", selectedId);
        }

        private void PopulateDrodDownList(Supplier supplier = null)
        {
            ViewData["SupplierID"] = SupplierSelectList(supplier?.SupplierId);
        }


        // GET: Item
        public async Task<IActionResult> Index(string SearchCode, int? SupplierID, int? page, int? pageSizeID,
            string actionButton, string sortDirection = "asc", string sortField = "Code")
        {
            //List of sort options.
            string[] sortOptions = new[] { "Number", "Name", "Description", "Supplier" };

            PopulateDrodDownList();

            var items = _context.Items
                .Include(i => i.Supplier)
                .AsNoTracking();

            //Filterig values                       
            if (!String.IsNullOrEmpty(SearchCode))
            {
                items = items.Where(s => s.ItemName.ToUpper().Contains(SearchCode.ToUpper())
                                        || s.Supplier.SupplierName.ToUpper().Contains(SearchCode.ToUpper()));
            }

            if (SupplierID.HasValue)
            {
                items = items.Where(s => s.Supplier.SupplierId == SupplierID);
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
            if (sortField == "Number")
            {
                if (sortDirection == "asc")
                {
                    items = items
                        .OrderBy(p => p.ItemNumber);
                }
                else
                {
                    items = items
                        .OrderByDescending(p => p.ItemNumber);
                }
            }
            else if (sortField == "Name")
            {
                if (sortDirection == "asc")
                {
                    items = items
                        .OrderBy(p => p.ItemName);
                }
                else
                {
                    items = items
                        .OrderByDescending(p => p.ItemName);
                }
            }
            else if (sortField == "Description")
            {
                if (sortDirection == "asc")
                {
                    items = items
                        .OrderBy(p => p.ItemDescription);
                }
                else
                {
                    items = items
                        .OrderByDescending(p => p.ItemDescription);
                }
            }
            else //Sorting by Supplier Name
            {
                if (sortDirection == "asc")
                {
                    items = items
                        .OrderBy(p => p.Supplier.SupplierName);
                }
                else
                {
                    items = items
                        .OrderByDescending(p => p.Supplier.SupplierName);
                }
            }
            //Set sort for next time
            ViewData["sortField"] = sortField;
            ViewData["sortDirection"] = sortDirection;

            //return View(await suppliers.ToListAsync());

            int pageSize = PageSizeHelper.SetPageSize(HttpContext, pageSizeID, ControllerName());
            ViewData["pageSizeID"] = PageSizeHelper.PageSizeList(pageSize);
            var pagedData = await PaginatedList<Item>.CreateAsync(items.AsNoTracking(), page ?? 1, pageSize);

            return View(pagedData);

        }

        // GET: Item/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Items == null)
            {
                return NotFound();
            }

            var item = await _context.Items
                .Include(i => i.Supplier)
                .FirstOrDefaultAsync(m => m.ItemId == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: Item/Create
        public IActionResult Create()
        {
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "SupplierCode");
            return View();
        }

        // POST: Item/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemId,ItemNumber,ItemName,ItemDescription,SupplierId")] Item item)
        {
            if (ModelState.IsValid)
            {
                _context.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "SupplierCode", item.SupplierId);
            return View(item);
        }

        // GET: Item/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Items == null)
            {
                return NotFound();
            }

            var item = await _context.Items.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "SupplierCode", item.SupplierId);
            return View(item);
        }

        // POST: Item/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemId,ItemNumber,ItemName,ItemDescription,SupplierId")] Item item)
        {
            if (id != item.ItemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(item.ItemId))
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
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "SupplierCode", item.SupplierId);
            return View(item);
        }

        // GET: Item/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Items == null)
            {
                return NotFound();
            }

            var item = await _context.Items
                .Include(i => i.Supplier)
                .FirstOrDefaultAsync(m => m.ItemId == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Item/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Items == null)
            {
                return Problem("Entity set 'HaverNiagaraContext.Items'  is null.");
            }
            var item = await _context.Items.FindAsync(id);
            if (item != null)
            {
                _context.Items.Remove(item);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemExists(int id)
        {
          return _context.Items.Any(e => e.ItemId == id);
        }
    }
}
