using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web_MVC_NET_5.Data;
using Web_MVC_NET_5.Models;

namespace Web_MVC_NET_5.Controllers
{
    public class ProduksiStringIDsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProduksiStringIDsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProduksiStringIDs
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProduksiStringIDs.ToListAsync());
        }

        // GET: ProduksiStringIDs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produksiStringID = await _context.ProduksiStringIDs
                .FirstOrDefaultAsync(m => m.PartNumber == id);
            if (produksiStringID == null)
            {
                return NotFound();
            }

            return View(produksiStringID);
        }

        // GET: ProduksiStringIDs/Create
        public IActionResult Create()
        {
            return View();

        }

        // POST: ProduksiStringIDs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PartNumber,Description")] ProduksiStringID produksiStringID)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produksiStringID);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(produksiStringID);
        }

        // GET: ProduksiStringIDs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produksiStringID = await _context.ProduksiStringIDs.FindAsync(id);
            if (produksiStringID == null)
            {
                return NotFound();
            }
            return View(produksiStringID);
        }

        // POST: ProduksiStringIDs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PartNumber,Description")] ProduksiStringID produksiStringID)
        {
            if (id != produksiStringID.PartNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produksiStringID);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProduksiStringIDExists(produksiStringID.PartNumber))
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
            return View(produksiStringID);
        }

        // GET: ProduksiStringIDs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produksiStringID = await _context.ProduksiStringIDs
                .FirstOrDefaultAsync(m => m.PartNumber == id);
            if (produksiStringID == null)
            {
                return NotFound();
            }

            return View(produksiStringID);
        }

        // POST: ProduksiStringIDs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var produksiStringID = await _context.ProduksiStringIDs.FindAsync(id);
            _context.ProduksiStringIDs.Remove(produksiStringID);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProduksiStringIDExists(string id)
        {
            return _context.ProduksiStringIDs.Any(e => e.PartNumber == id);
        }
    }
}
