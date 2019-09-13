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
    public class ReserveSpotsController : Controller
    {
        private readonly KeeParkContext _context;

        public ReserveSpotsController(KeeParkContext context)
        {
            _context = context;
        }

        // GET: ReserveSpots
        public async Task<IActionResult> Index()
        {
            var keeParkContext = _context.ReserveSpot.Include(r => r.Spot).Include(r => r.User);
            return View(await keeParkContext.ToListAsync());
        }

        // GET: ReserveSpots/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserveSpot = await _context.ReserveSpot
                .Include(r => r.Spot)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.ReserveSpotID == id);
            if (reserveSpot == null)
            {
                return NotFound();
            }

            return View(reserveSpot);
        }

        // GET: ReserveSpots/Create
        public IActionResult Create()
        {
            ViewData["SpotID"] = new SelectList(_context.ParkingSpot, "ParkingSpotID", "ParkingSpotID");
            ViewData["UserID"] = new SelectList(_context.GeneralUser, "ID", "ID");
            return View();
        }

        // POST: ReserveSpots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReserveSpotID,UserID,SpotID,CreatedOn,ReservationDate,ReservationHour,Duration")] ReserveSpot reserveSpot)
        {
            if (ModelState.IsValid)
            {
                reserveSpot.ReserveSpotID = Guid.NewGuid();
                _context.Add(reserveSpot);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SpotID"] = new SelectList(_context.ParkingSpot, "ParkingSpotID", "ParkingSpotID", reserveSpot.SpotID);
            ViewData["UserID"] = new SelectList(_context.GeneralUser, "ID", "ID", reserveSpot.UserID);
            return View(reserveSpot);
        }

        // GET: ReserveSpots/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserveSpot = await _context.ReserveSpot.FindAsync(id);
            if (reserveSpot == null)
            {
                return NotFound();
            }
            ViewData["SpotID"] = new SelectList(_context.ParkingSpot, "ParkingSpotID", "ParkingSpotID", reserveSpot.SpotID);
            ViewData["UserID"] = new SelectList(_context.GeneralUser, "ID", "ID", reserveSpot.UserID);
            return View(reserveSpot);
        }

        // POST: ReserveSpots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ReserveSpotID,UserID,SpotID,CreatedOn,ReservationDate,ReservationHour,Duration")] ReserveSpot reserveSpot)
        {
            if (id != reserveSpot.ReserveSpotID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reserveSpot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReserveSpotExists(reserveSpot.ReserveSpotID))
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
            ViewData["SpotID"] = new SelectList(_context.ParkingSpot, "ParkingSpotID", "ParkingSpotID", reserveSpot.SpotID);
            ViewData["UserID"] = new SelectList(_context.GeneralUser, "ID", "ID", reserveSpot.UserID);
            return View(reserveSpot);
        }

        // GET: ReserveSpots/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserveSpot = await _context.ReserveSpot
                .Include(r => r.Spot)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.ReserveSpotID == id);
            if (reserveSpot == null)
            {
                return NotFound();
            }

            return View(reserveSpot);
        }

        // POST: ReserveSpots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var reserveSpot = await _context.ReserveSpot.FindAsync(id);
            _context.ReserveSpot.Remove(reserveSpot);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReserveSpotExists(Guid id)
        {
            return _context.ReserveSpot.Any(e => e.ReserveSpotID == id);
        }
    }
}
