using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeePark.Models
{
    public class ParkingSpot
    {
        public Guid ParkingSpotID { get; set; }
        public int Price { get; set; }
        public int NunOfOrders { get; set; }
        public IFormFile parkinPhoto { get; set; }
    }
}
