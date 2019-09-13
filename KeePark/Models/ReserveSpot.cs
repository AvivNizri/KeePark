using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeepPark.Models
{
    public class ReserveSpot
    {
        public Guid ReserveSpotID { get; set; }
        public string UserID { get; set; }
        public GeneralUser User { get; set; }  //object of type private user
        public Guid SpotID { get; set; }
        public ParkingSpot Spot { get; set; } //object of type Parking Spot
        [DataType(DataType.Date)]
        public DateTime CreatedOn { get; set; } //date only
        [DataType(DataType.Date)]
        public DateTime ReservationDate { get; set; } //date only
        public int ReservationHour { get; set; } //between 0-23
        public int Duration { get; set; } //1/2

   
    }
}
