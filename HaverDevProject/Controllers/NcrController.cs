﻿using System;
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
    public class NcrController : Controller
    {
        private readonly HaverNiagaraContext _context;

        public NcrController(HaverNiagaraContext context)
        {
            _context = context;
        }

        // GET: Ncr
        public async Task<IActionResult> Index()
        {
            var haverNiagaraContext = _context.Ncrs.Include(n => n.StatusUpdate)
                .Include(n=>n.NcrEngs)
                .Include(n=>n.NcrQas).AsNoTracking();
            return View(await haverNiagaraContext.ToListAsync());
        }

        // GET: Ncr/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Ncrs == null)
            {
                return NotFound();
            }

            var ncr = await _context.Ncrs
                .Include(n => n.StatusUpdate)
                .FirstOrDefaultAsync(m => m.NcrId == id);
            if (ncr == null)
            {
                return NotFound();
            }

            return View(ncr);
        }

        // GET: Ncr/Create
        public IActionResult Create()
        {
            ViewData["StatusUpdateId"] = new SelectList(_context.StatusUpdates, "StatusUpdateId", "StatusUpdateName");
            return View();
        }

        // POST: Ncr/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NcrId,NcrNumber,NcrLastUpdated,StatusUpdateId")] Ncr ncr)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ncr);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StatusUpdateId"] = new SelectList(_context.StatusUpdates, "StatusUpdateId", "StatusUpdateName", ncr.StatusUpdateId);
            return View(ncr);
        }

        // GET: Ncr/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Ncrs == null)
            {
                return NotFound();
            }

            var ncr = await _context.Ncrs.FindAsync(id);
            if (ncr == null)
            {
                return NotFound();
            }
            ViewData["StatusUpdateId"] = new SelectList(_context.StatusUpdates, "StatusUpdateId", "StatusUpdateName", ncr.StatusUpdateId);
            return View(ncr);
        }

        // POST: Ncr/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NcrId,NcrNumber,NcrLastUpdated,StatusUpdateId")] Ncr ncr)
        {
            if (id != ncr.NcrId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ncr);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NcrExists(ncr.NcrId))
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
            ViewData["StatusUpdateId"] = new SelectList(_context.StatusUpdates, "StatusUpdateId", "StatusUpdateName", ncr.StatusUpdateId);
            return View(ncr);
        }

        // GET: Ncr/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Ncrs == null)
            {
                return NotFound();
            }

            var ncr = await _context.Ncrs
                .Include(n => n.StatusUpdate)
                .FirstOrDefaultAsync(m => m.NcrId == id);
            if (ncr == null)
            {
                return NotFound();
            }

            return View(ncr);
        }

        // POST: Ncr/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Ncrs == null)
            {
                return Problem("Entity set 'HaverNiagaraContext.Ncrs'  is null.");
            }
            var ncr = await _context.Ncrs.FindAsync(id);
            if (ncr != null)
            {
                _context.Ncrs.Remove(ncr);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NcrExists(int id)
        {
          return _context.Ncrs.Any(e => e.NcrId == id);
        }
    }
}