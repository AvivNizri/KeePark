using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KeePark.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry, the resource you requested could not be found (404 error)";
                    break;

                case 500:
                    ViewBag.ErrorMessage = "Sorry, the resource you requested could not be found (500 error)";
                    break;

                default:
                    break;
            }
            return View("NotFound");
        }
    }
}