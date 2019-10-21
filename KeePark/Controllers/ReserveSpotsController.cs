using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KeePark.Models;
using KeePark.Data;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Text;

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
            var userid = (from myid in _identitycontext.GeneralUser
                          where myid.Email == User.Identity.Name
                          select myid.UID).FirstOrDefault();

            var viewModel = new ReserveSpot
            {

                carNumber = carN,
                ReservationDate= System.DateTime.Now,
                CreatedOn= System.DateTime.Now,

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

                if ((!(reserveSpot.ReservationDate < System.DateTime.Now))||(reserveSpot.ReservationDate.Date == DateTime.Today))
                {

                    if ((reserveSpot.ReservationHour <= System.DateTime.Now.Hour)&&((reserveSpot.ReservationDate.Date == DateTime.Today)))
                        return RedirectToAction(nameof(InvalidHour));

                    
                  

                    var user = (from bla in _identitycontext.GeneralUser
                                        where bla.UserName == User.Identity.Name
                                        select bla).FirstOrDefault();
                            var userid = (from bla in _identitycontext.GeneralUser
                                        where bla.UserName == User.Identity.Name
                                        select bla.UID).FirstOrDefault();
     
                            Guid er = new Guid("c6788e87-b95a-4af9-af8e-5de7c3bff701"); //delete
                            reserveSpot.ReserveSpotID = Guid.NewGuid();
                            reserveSpot.CreatedOn = System.DateTime.Now;
                            reserveSpot.Spot = _context.ParkingSpot.FirstOrDefault(u => u.ParkingSpotID ==er);

                             int count = 0;
                             foreach (var t in _context.ReserveSpot)
                             {
                                 if (userid == t.UserID)
                                 {
                                     count++;
                                 }

                             }

                             if (count==0 && !(_context.GeneralUser.Contains(user)))
                             {
                                 reserveSpot.User = _identitycontext.GeneralUser.FirstOrDefault(u => u.UserName == User.Identity.Name);
                                 reserveSpot.UserID = reserveSpot.User.UID;

                             }
                             else
                             {

                                 reserveSpot.UserID = userid;
                             }


                              var myreservations = (from reservations in _context.ReserveSpot
                                                     where reservations.Spot.ParkingSpotID == er   //replace
                                                     select reservations);
                               var m = (from t in myreservations
                                        where t.ReservationDate == reserveSpot.ReservationDate
                                        select t);

                               foreach (var t in m) {
                                   if ((t.ReservationHour <= reserveSpot.ReservationHour) && (reserveSpot.ReservationHour < t.ReservationHour + t.Duration))
                                   {
                                         return RedirectToAction(nameof(SorrySpotIsTaken));
                        }

                                     }

                    var reserves = from res in _context.ReserveSpot
                                   where res.ReservationDate == reserveSpot.ReservationDate && res.SpotID == er
                                       select res;
                    foreach(var r in reserves){

                        if ((reserveSpot.ReservationHour < r.ReservationHour + r.Duration && reserveSpot.ReservationHour >= r.ReservationHour))
                        {
                            return RedirectToAction(nameof(SorrySpotIsTaken));
                        }
                        if ((reserveSpot.ReservationHour + reserveSpot.Duration <= r.ReservationHour + r.Duration)&&(reserveSpot.ReservationHour+reserveSpot.Duration>r.ReservationHour))
                        {
                            return RedirectToAction(nameof(SorrySpotIsTaken));
                        }
                        if((reserveSpot.ReservationHour<=r.ReservationHour) && (reserveSpot.ReservationHour + reserveSpot.Duration >= r.ReservationHour + r.Duration))
                        {
                            return RedirectToAction(nameof(SorrySpotIsTaken));
                        }

                    }
                    if (reserveSpot.ReservationHour + reserveSpot.Duration > 24)
                    {
                        return RedirectToAction(nameof(SorryChooseDurationForTheDayYouSelected));
                    }




                    reserveSpot.Spot.NunOfOrders++;
                    _context.Add(reserveSpot);

                       
                   await _context.SaveChangesAsync();
                   
                            
                   return RedirectToAction(nameof(Index));

                }

                else
                {
                    return RedirectToAction(nameof(InvalidDate));

                }


            }

           // ViewData["UserID"] = new SelectList(_identitycontext.GeneralUser, "UID", "UID", reserveSpot.UserID);
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

        public IActionResult SorrySpotIsTaken()
        {
            return View();
        }

        public IActionResult SorryChooseDurationForTheDayYouSelected()
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
                if ((!(reserveSpot.ReservationDate < System.DateTime.Now)) || (reserveSpot.ReservationDate.Date == DateTime.Today))
                {
                    if ((reserveSpot.ReservationHour <= System.DateTime.Now.Hour) && ((reserveSpot.ReservationDate.Date == DateTime.Today)))
                        return RedirectToAction(nameof(InvalidHour));

                    try
                    {
                        var spotid = (from myid in _context.ReserveSpot
                                      where myid.ReserveSpotID == id
                                      select myid.SpotID).FirstOrDefault();
                        reserveSpot.User = _identitycontext.GeneralUser.FirstOrDefault(u => u.UserName == User.Identity.Name);
                        reserveSpot.UserID = reserveSpot.User.UID;
                        reserveSpot.Spot = _context.ParkingSpot.FirstOrDefault(u => u.ParkingSpotID == spotid);
                        reserveSpot.SpotID = reserveSpot.Spot.ParkingSpotID;
                        reserveSpot.CreatedOn = System.DateTime.Now;

                        var res = from reserve in _context.ReserveSpot
                                  where reserve.ReserveSpotID != id
                                  select reserve;
                        var spots = from sp in res
                                    where sp.Spot.ParkingSpotID == reserveSpot.SpotID && sp.ReservationDate== reserveSpot.ReservationDate
                                    select sp;

                        foreach (var t in spots)
                        {
                            if ((t.ReservationHour <= reserveSpot.ReservationHour) && (reserveSpot.ReservationHour < t.ReservationHour + t.Duration))
                            {
                                return RedirectToAction(nameof(SorrySpotIsTaken));
                            }
                        }

                        
                        foreach (var r in spots)
                        {

                            if ((reserveSpot.ReservationHour < r.ReservationHour + r.Duration && reserveSpot.ReservationHour >= r.ReservationHour))
                            {
                                return RedirectToAction(nameof(SorrySpotIsTaken));
                            }
                            if ((reserveSpot.ReservationHour + reserveSpot.Duration <= r.ReservationHour + r.Duration) && (reserveSpot.ReservationHour + reserveSpot.Duration > r.ReservationHour))
                            {
                                return RedirectToAction(nameof(SorrySpotIsTaken));
                            }
                            if ((reserveSpot.ReservationHour <= r.ReservationHour) && (reserveSpot.ReservationHour + reserveSpot.Duration >= r.ReservationHour + r.Duration))
                            {
                                return RedirectToAction(nameof(SorrySpotIsTaken));
                            }

                        }
                        if (reserveSpot.ReservationHour + reserveSpot.Duration > 24)
                        {
                            return RedirectToAction(nameof(SorryChooseDurationForTheDayYouSelected));
                        }

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

                else
                {
                    return RedirectToAction(nameof(InvalidDate));

                }

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


        public IActionResult Weather()
        {
            return View();
        }




    }
}
