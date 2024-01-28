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
    public class DefectsController : ElephantController
    {
        private readonly HaverNiagaraContext _context;

        public DefectsController(HaverNiagaraContext context)
        {
            _context = context;
        }

        // GET: Defects
        public async Task<IActionResult> Index(string SearchName, int? page, int? pageSizeID,
            string actionButton, string sortDirection = "asc", string sortField = "Defect")
        {
            //List of sort options.
            string[] sortOptions = new[] {"Defect"};

            var items = _context.Defects
                .AsNoTracking();

            //Filterig values                       
            if (!String.IsNullOrEmpty(SearchName))
            {
                items = items.Where(s => s.DefectName.ToUpper().Contains(SearchName.ToUpper()));
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
            if (sortField == "Defect")
            {
                if (sortDirection == "asc")
                {
                    items = items
                        .OrderBy(p => p.DefectName);
                }
                else
                {
                    items = items
                        .OrderByDescending(p => p.DefectName);
                }
            }

            //Set sort for next time
            ViewData["sortField"] = sortField;
            ViewData["sortDirection"] = sortDirection;

            //return View(await suppliers.ToListAsync());

            int pageSize = PageSizeHelper.SetPageSize(HttpContext, pageSizeID, ControllerName());
            ViewData["pageSizeID"] = PageSizeHelper.PageSizeList(pageSize);
            var pagedData = await PaginatedList<Defect>.CreateAsync(items.AsNoTracking(), page ?? 1, pageSize);

            return View(pagedData);

        }

        // GET: Defects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Defects == null)
            {
                return NotFound();
            }

            var defect = await _context.Defects
                .FirstOrDefaultAsync(m => m.DefectId == id);
            if (defect == null)
            {
                return NotFound();
            }

            return View(defect);
        }

        // GET: Defects/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Defects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DefectId,DefectName,DefectDesription")] Defect defect)
        {
            if (ModelState.IsValid)
            {
                _context.Add(defect);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(defect);
        }

        // GET: Defects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Defects == null)
            {
                return NotFound();
            }

            var defect = await _context.Defects.FindAsync(id);
            if (defect == null)
            {
                return NotFound();
            }
            return View(defect);
        }

        // POST: Defects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DefectId,DefectName,DefectDesription")] Defect defect)
        {
            if (id != defect.DefectId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(defect);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DefectExists(defect.DefectId))
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
            return View(defect);
        }

        // GET: Defects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Defects == null)
            {
                return NotFound();
            }

            var defect = await _context.Defects
                .FirstOrDefaultAsync(m => m.DefectId == id);
            if (defect == null)
            {
                return NotFound();
            }

            return View(defect);
        }

        // POST: Defects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Defects == null)
            {
                return Problem("Entity set 'HaverNiagaraContext.Defects'  is null.");
            }
            var defect = await _context.Defects.FindAsync(id);
            if (defect != null)
            {
                _context.Defects.Remove(defect);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DefectExists(int id)
        {
          return _context.Defects.Any(e => e.DefectId == id);
        }
    }
}
