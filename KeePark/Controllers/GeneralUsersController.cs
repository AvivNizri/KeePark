using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KeePark.Models;
using KeepPark.Models;
using Microsoft.AspNetCore.Authorization;

namespace KeePark.Controllers
{
    public class GeneralUsersController : Controller
    {
        private readonly KeeParkContext _context;

        public GeneralUsersController(KeeParkContext context)
        {
            _context = context;
        }

        // GET: GeneralUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.GeneralUser.ToListAsync());
        }

        // GET: UserProfile
        public async Task<IActionResult> UserProfile()
        {
            return View(await _context.GeneralUser.ToListAsync());
        }

        // GET: GeneralUsers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalUser = await _context.GeneralUser
                .FirstOrDefaultAsync(m => m.ID == id);
            if (generalUser == null)
            {
                return NotFound();
            }

            return View(generalUser);
        }

        // GET: GeneralUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GeneralUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,Email,Password,CreditCard,CarNumber,CarType,Address,PhoneNumber,Balance")] GeneralUser generalUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(generalUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(generalUser);
        }

        // GET: GeneralUsers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalUser = await _context.GeneralUser.FindAsync(id);
            if (generalUser == null)
            {
                return NotFound();
            }
            return View(generalUser);
        }

        // POST: GeneralUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,FirstName,LastName,Email,Password,CreditCard,CarNumber,CarType,Address,PhoneNumber,Balance")] GeneralUser generalUser)
        {
            if (id != generalUser.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(generalUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GeneralUserExists(generalUser.ID))
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
            return View(generalUser);
        }

        // GET: GeneralUsers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalUser = await _context.GeneralUser
                .FirstOrDefaultAsync(m => m.ID == id);
            if (generalUser == null)
            {
                return NotFound();
            }

            return View(generalUser);
        }

        // POST: GeneralUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var generalUser = await _context.GeneralUser.FindAsync(id);
            _context.GeneralUser.Remove(generalUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GeneralUserExists(string id)
        {
            return _context.GeneralUser.Any(e => e.ID == id);
        }
    }
}
