using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KeePark.Models;
using KeepPark.Models;

namespace KeePark.Controllers
{
    public class ParkingSpotsController : Controller
    {
        private readonly KeeParkContext _context;

        public ParkingSpotsController(KeeParkContext context)
        {
            _context = context;
        }

        // GET: ParkingSpots
        public async Task<IActionResult> Index()
        {
            return View(await _context.ParkingSpot.ToListAsync());
        }

        // GET: ParkingSpots/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parkingSpot = await _context.ParkingSpot
                .FirstOrDefaultAsync(m => m.ParkingSpotID == id);
            if (parkingSpot == null)
            {
                return NotFound();
            }

            return View(parkingSpot);
        }

        // GET: ParkingSpots/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ParkingSpots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ParkingSpotID,X,Y")] ParkingSpot parkingSpot)
        {
            if (ModelState.IsValid)
            {
                parkingSpot.ParkingSpotID = Guid.NewGuid();
                _context.Add(parkingSpot);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parkingSpot);
        }

        // GET: ParkingSpots/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parkingSpot = await _context.ParkingSpot.FindAsync(id);
            if (parkingSpot == null)
            {
                return NotFound();
            }
            return View(parkingSpot);
        }

        // POST: ParkingSpots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ParkingSpotID,X,Y")] ParkingSpot parkingSpot)
        {
            if (id != parkingSpot.ParkingSpotID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parkingSpot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParkingSpotExists(parkingSpot.ParkingSpotID))
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
            return View(parkingSpot);
        }

        // GET: ParkingSpots/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parkingSpot = await _context.ParkingSpot
                .FirstOrDefaultAsync(m => m.ParkingSpotID == id);
            if (parkingSpot == null)
            {
                return NotFound();
            }

            return View(parkingSpot);
        }

        // POST: ParkingSpots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var parkingSpot = await _context.ParkingSpot.FindAsync(id);
            _context.ParkingSpot.Remove(parkingSpot);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParkingSpotExists(Guid id)
        {
            return _context.ParkingSpot.Any(e => e.ParkingSpotID == id);
        }
    }
}
