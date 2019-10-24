using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KeePark.Models;
using KeePark.ViewModels;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace KeePark.Controllers
{
    public class ParkingSpotsController : Controller
    {
        private readonly KeeParkContext _context;
        private readonly IdentityContext _identity;
        private readonly IHostingEnvironment hostingEnvironment;

        public ParkingSpotsController(IHostingEnvironment hostingEnviroment, KeeParkContext context, IdentityContext identity)
        {
            this.hostingEnvironment = hostingEnviroment;
            this._identity = identity;
            _context = context;
        }

        // GET: ParkingSpots
        public async Task<IActionResult> Index()
        {
            return View(await _context.ParkingSpot.ToListAsync());
        }

        // GET: ParkingSpots/Details/5
        public async Task<IActionResult> Details(int? id)
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
        public async Task<IActionResult> Create([Bind("ParkingSpotID,SpotName,OwnerID,Address,Price,NunOfOrders,filePath,SpotDescription,parkingPhoto")] ParkingSpotCreate parkingSpot)
        {
            var currentUser = (from userID in _identity.GeneralUser
                               where userID.Id == User.FindFirstValue(ClaimTypes.NameIdentifier)
                               select userID.UID).FirstOrDefault();

            var numOfSpots = _context.ParkingSpot.Count();
                              
            if (ModelState.IsValid)
            {
                string FileName = null;
                if (parkingSpot.parkingPhoto != null)
                {
                    string UploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "SpotImages");
                    FileName = Guid.NewGuid().ToString() + "_" + parkingSpot.parkingPhoto.FileName;
                    
                    string filePath = Path.Combine(UploadFolder, FileName);
                    //string filePath = Path.GetDirectoryName(Path.Combine(UploadFolder,FileName));
                    //parkingSpot.parkingPhoto.CopyTo(new FileStream(filePath, FileMode.Create));
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await parkingSpot.parkingPhoto.CopyToAsync(fileStream);
                    }
                }
                ParkingSpot newSpot = new ParkingSpot
                {
                    ParkingSpotID = numOfSpots + 1,
                    SpotName = parkingSpot.SpotName,
                    OwnerID = currentUser,
                    Address = parkingSpot.Address,
                    Price = parkingSpot.Price,
                    NunOfOrders = 0,
                    SpotDescription = parkingSpot.SpotDescription,
                    filePath = FileName
                };
                _context.Add(newSpot);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", new { id = newSpot.ParkingSpotID });
            }
            return View(parkingSpot);
        }

        // GET: ParkingSpots/Edit/5
        public async Task<IActionResult> Edit(int? id)
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
        public async Task<IActionResult> Edit(int id, [Bind("ParkingSpotID,SpotName,OwnerID,Address,Price,NunOfOrders,filePath,SpotDescription")] ParkingSpot parkingSpot,
            IFormFile file)
        {
            

            if (id != parkingSpot.ParkingSpotID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (file != null)
                    {
                        string UploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "SpotImages");
                        var FileName = Guid.NewGuid().ToString() + "_" + file.FileName;

                        string filePath = Path.Combine(UploadFolder, FileName);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await file.CopyToAsync(fileStream);
                        }
                        parkingSpot.filePath = FileName;
                    }
                    else {
                        // without doing those linq calls we saw that the edit causing disapearnce of data!
                        parkingSpot.filePath = (from spotID in _context.ParkingSpot
                                                where spotID.ParkingSpotID.ToString() == parkingSpot.ParkingSpotID.ToString()
                                                select spotID.filePath).FirstOrDefault();

                        parkingSpot.OwnerID = (from owner in _context.ParkingSpot
                                               where owner.ParkingSpotID.ToString() == parkingSpot.ParkingSpotID.ToString()
                                               select owner.OwnerID).FirstOrDefault();
                    }
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
        public async Task<IActionResult> Delete(int? id)
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

        private bool ParkingSpotExists(int id)
        {
            return _context.ParkingSpot.Any(e => e.ParkingSpotID == id);
        }
    }
}