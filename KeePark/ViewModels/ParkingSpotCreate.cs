using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeePark.ViewModels
{
    public class ParkingSpotCreate
    {
        [Required]
        [Display(Name = "Parking Name")]
        public string SpotName { get; set; }
        [Required]
        [Display(Name = "Parking Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Price")]
        public int Price { get; set; }
        [Display(Name = "Describe Your Parking")]
        public string SpotDescription { get; set; }
        public IFormFile parkingPhoto { get; set; }
        //public Enum Label { get; set; }//Optional ToDo OptionSet - raz todo
    }
}
