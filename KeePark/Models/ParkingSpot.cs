using KeePark.Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeePark.Models
{
    public class ParkingSpot
    {
        [Key]
        public Guid ParkingSpotID { get; set; }
        [Required]
        [Display(Name = "Parking Name")]
        public string SpotName { get; set; }
        public string OwnerID { get; set; }
        // ?needed? public GeneralUser User { get; set; }
        [Required]
        [Display(Name = "Parking Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Price")]
        public int Price { get; set; }
        public int NunOfOrders { get; set; }
        public string filePath { get; set; }
        [Display(Name = "Describe Your Parking")]
        public string SpotDescription { get; set; }
        //public Enum Label { get; set; }//Optional ToDo OptionSet - raz todo
    }
}
