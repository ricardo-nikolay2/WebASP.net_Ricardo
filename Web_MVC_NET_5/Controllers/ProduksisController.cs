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
    public class ProduksisController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProduksisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Produksis
        public async Task<IActionResult> Index()
        {
            return View(await _context.Produksis.ToListAsync());
        }

        // GET: Produksis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produksi = await _context.Produksis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produksi == null)
            {
                return NotFound();
            }

            return View(produksi);
        }

        // GET: Produksis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Produksis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PartNumber")] Produksi produksi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produksi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(produksi);
        }

        // GET: Produksis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produksi = await _context.Produksis.FindAsync(id);
            if (produksi == null)
            {
                return NotFound();
            }
            return View(produksi);
        }

        // POST: Produksis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PartNumber")] Produksi produksi)
        {
            if (id != produksi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produksi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProduksiExists(produksi.Id))
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
            return View(produksi);
        }

        // GET: Produksis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produksi = await _context.Produksis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produksi == null)
            {
                return NotFound();
            }

            return View(produksi);
        }

        // POST: Produksis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produksi = await _context.Produksis.FindAsync(id);
            _context.Produksis.Remove(produksi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProduksiExists(int id)
        {
            return _context.Produksis.Any(e => e.Id == id);
        }
    }
}
