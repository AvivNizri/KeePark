using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KeePark.Models;
using Microsoft.AspNetCore.Mvc;
using KeePark.Data;
using System.Text;
using Microsoft.AspNetCore.Authorization;

namespace KeePark.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class StatisticsController : Controller
    {
        private readonly KeeParkContext _context;
        private readonly IdentityContext _identitycontext;

        public StatisticsController(KeeParkContext context, IdentityContext identitycontext)
        {
            _context = context;
            _identitycontext = identitycontext;
        }

        //Counter of orders by user
        public IActionResult UserStat()
        {
            var t = from u in _context.ReserveSpot
                    where u.CreatedOn.Year == System.DateTime.Today.Year
                    select u;

            var groupJoinQuery =
            from orders in t
            join users in _context.ReserveSpot on orders.UserID equals users.UserID into uorderGroup
           from uorder in uorderGroup
           group uorder by uorder.UserID into g
             select new { Name =g.Key, Count = g.Count() };


                     var list = (from mygroup in groupJoinQuery
                                 orderby mygroup.Count descending
                                 select mygroup).Take(5);

            Dictionary<string, int> map;
        

            map = list.ToList().ToDictionary(a => a.Name, a => a.Count);
            ViewBag.Map = map;
            return View();
        }

        public IActionResult PopularSpot()
        {
            

            return View();
        }
        public string GetData()
        {
            Dictionary<string, int> map1;
            var spots = (from s in _context.ParkingSpot
                         orderby s.NunOfOrders descending
                         select s).Take(5);

       
            StringBuilder output = new StringBuilder();
            output.Append("name,value\n");

            foreach (var item in spots)
            {
                output.Append(item.SpotName+","+item.NunOfOrders + "\n");
            }

            return output.ToString();
        }
    }
}