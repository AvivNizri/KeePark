using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KeePark.Models;
using Microsoft.AspNetCore.Authorization;
using KeePark.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace KeePark.Controllers
{
    public class HomeController : Controller
    {
        private readonly KeeParkContext _KeeParkContext;
        private readonly IdentityContext _IdentityContext;
    //    private readonly MLApriori _mlApriori;
        private readonly IHostingEnvironment _hostingEnvironment;

        public HomeController(IdentityContext db, KeeParkContext kpb,  IHostingEnvironment hostingEnvironment)
        {
            _IdentityContext = db;
            _KeeParkContext = kpb;
            _hostingEnvironment = hostingEnvironment;
            // init the MLApriori
           // _mlApriori = mlalgo;
        }
              public async Task<IActionResult> Index()
           {
               if (User.Identity.IsAuthenticated) {
                   // finding current user by name
                   var uName = User.Identity.Name;
                   var thisUser = await _IdentityContext.GeneralUser.FirstOrDefaultAsync(u => u.UserName.Equals(uName));

                   // validation thisUser really exists
                   if (thisUser == null)
                       return NotFound();

                 //  ViewBag.recomended = _mlApriori.GetRecommendedSpots(thisUser.History.Split(",").Select(int.Parse).ToArray());
               }
               return View();
           }

       /* public IActionResult Index()
        {
            return View();
        }*/


        public IActionResult UserProfile() ///////added
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
