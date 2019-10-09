using KeePark.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeePark.Models
{
    public class Site
    {
        public Guid SiteID { get; set; } //ToDo auto generated
        public string SiteName { get; set; }
        public string OwnerID { get; set; }
        public GeneralUser User { get; set; }
        public ParkingSpot ParkingSpot { get; set; }
        public string Address { get; set; }
        public string SiteDescription { get; set; }
        public string SitePhoneNumber { get; set; }
        public double PricePerHour { get; set; }
        //public Enum Label { get; set; }//Optional ToDo OptionSet - raz todo
    }
}
