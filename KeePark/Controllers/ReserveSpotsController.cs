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
            var carN = (from mycar in _identitycontext.GeneralUser
                          where mycar.Email == User.Identity.Name
                          select mycar.CarNumber).FirstOrDefault();

         //   ViewData["carNumber"] = new SelectList(_identitycontext.GeneralUser, "carNumber", "carNumber", carN);
            var viewModel = new ReserveSpot
            {

                carNumber = carN,
                ReservationDate= System.DateTime.Now,
                CreatedOn= System.DateTime.Now

            };

            return View(viewModel);
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
                

                if (!(reserveSpot.ReservationDate.Year<System.DateTime.Today.Year))
                {
                   if(!(reserveSpot.ReservationDate.Month < System.DateTime.Today.Month))
                    {
                        if(!(reserveSpot.ReservationDate.Day < System.DateTime.Today.Day))
                        {
                            if ((reserveSpot.ReservationDate.Day== System.DateTime.Today.Day))
                            {
                                if((reserveSpot.ReservationHour <= System.DateTime.Now.Hour))
                                    return RedirectToAction(nameof(InvalidHour));
                            }

                            var userid = (from myid in _identitycontext.GeneralUser
                                          where myid.Email == User.Identity.Name
                                          select myid.UID).FirstOrDefault();
                           /* var user = (from myid in _identitycontext.GeneralUser
                                          where myid.Email == User.Identity.Name
                                          select myid).FirstOrDefault();*/

                            Guid er = new Guid("8bf6c17c-3c2d-4cce-a0f3-24af9d7b17c6"); //delete

                           

                            var myreservations = (from reservations in _context.ReserveSpot
                                                 where reservations.SpotID ==er
                                                 select reservations);
                            var m = (from t in myreservations
                                     where t.ReservationDate == reserveSpot.ReservationDate
                                                  select t);

                        foreach(var t in m) { 
                            if ((t.ReservationHour <= reserveSpot.ReservationHour) && (reserveSpot.ReservationHour < t.ReservationHour + t.Duration))
                            {
                                return NotFound();
                            }
                        }

                            ReserveSpot newReservation = new ReserveSpot
                            {
                                ReserveSpotID = Guid.NewGuid(),
                               // User = user,
                                UserID = userid,
                                Spot=reserveSpot.Spot,
                                SpotID = er, //get from constructor
                                CreatedOn = System.DateTime.Now,
                                ReservationDate = reserveSpot.ReservationDate,
                                ReservationHour = reserveSpot.ReservationHour,
                                Duration = reserveSpot.Duration,
                                carNumber = reserveSpot.carNumber

                            };

                        //    reserveSpot.SpotID = newReservation.SpotID;
                       //     reserveSpot.UserID = newReservation.UserID;

                            _context.Add(newReservation);

                            await _context.SaveChangesAsync();
                            return RedirectToAction(nameof(Index));


                        }

                    }
                }

                else
                {
                    return RedirectToAction(nameof(InvalidDate));

                }


            }

            return View(reserveSpot);
        }


        public IActionResult InvalidHour()
        {
            return View();
        }

        public IActionResult InvalidDate()
        {
            return View();
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
            ViewData["SpotID"] = new SelectList(_context.ReserveSpot, "SpotID", "SpotID", reserveSpot.SpotID);
            ViewData["UserID"] = new SelectList(_context.ReserveSpot, "UserID", "UserID", reserveSpot.UserID);
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
                    var spotid = (from myid in _context.ReserveSpot
                                  where myid.ReserveSpotID == id
                                  select myid.SpotID).FirstOrDefault();
                    reserveSpot.User=_identitycontext.GeneralUser.FirstOrDefault(u => u.UserName == User.Identity.Name);
                    reserveSpot.UserID = reserveSpot.User.UID;
                    reserveSpot.Spot = _context.ParkingSpot.FirstOrDefault(u => u.ParkingSpotID == spotid);
                    reserveSpot.SpotID = reserveSpot.Spot.ParkingSpotID;
                    // _context.ReserveSpot.Update(reserveSpot);
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
            ViewData["SpotID"] = new SelectList(_context.ReserveSpot, "SpotID", "SpotID", reserveSpot.SpotID);
            ViewData["UserID"] = new SelectList(_context.ReserveSpot, "UserID", "UserID", reserveSpot.UserID);
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
