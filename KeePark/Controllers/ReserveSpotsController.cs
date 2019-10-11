using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KeePark.Models;
using KeePark.Data;

namespace KeePark.Controllers
{
    public class ReserveSpotsController : Controller
    {
        private readonly KeeParkContext _context;
        private readonly IdentityContext _identitycontext;

        public ReserveSpotsController(KeeParkContext context, IdentityContext identitycontext)
        {
            _context = context;
            _identitycontext = identitycontext;
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
          
            return View();
        }

        // POST: ReserveSpots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReserveSpotID,UserID,SpotID,CreatedOn,ReservationDate,ReservationHour,Duration,carNumber")] ReserveSpot reserveSpot, Guid parkingSpotID)
        {
            if (ModelState.IsValid)
            {
                var user = (from myid in _identitycontext.GeneralUser
                            where myid.Email == User.Identity.Name
                            select myid).FirstOrDefault();


                Guid er = new Guid("8bf6c17c-3c2d-4cce-a0f3-24af9d7b17c6"); //delete
                ReserveSpot newReservation = new ReserveSpot
                {
                    ReserveSpotID = Guid.NewGuid(),
                    User = user,
                    UserID = user.UID,
                    SpotID = er, //get from constructor
                    CreatedOn = System.DateTime.Now,
                    ReservationDate = reserveSpot.ReservationDate,
                    ReservationHour = reserveSpot.ReservationHour,
                    Duration = reserveSpot.Duration,
                    carNumber = reserveSpot.carNumber

                };


                _context.Add(newReservation);
        
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));


            }

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
            ViewData["SpotID"] = new SelectList(_context.ParkingSpot, "ParkingSpotID", "Address", reserveSpot.SpotID);
            ViewData["UserID"] = new SelectList(_context.Set<GeneralUser>(), "UID", "UID", reserveSpot.UserID);
            return View(reserveSpot);
        }

        // POST: ReserveSpots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ReserveSpotID,UserID,SpotID,CreatedOn,ReservationDate,ReservationHour,Duration,carNumber")] ReserveSpot reserveSpot)
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
            ViewData["SpotID"] = new SelectList(_context.ParkingSpot, "ParkingSpotID", "Address", reserveSpot.SpotID);
            ViewData["UserID"] = new SelectList(_context.Set<GeneralUser>(), "UID", "UID", reserveSpot.UserID);
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
