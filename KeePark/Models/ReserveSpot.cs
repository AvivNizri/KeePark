using KeePark.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeePark.Models
{
    public class ReserveSpot
    {
        [HiddenInput]
        public Guid ReserveSpotID { get; set; }
        public string UserID { get; set; }
        public GeneralUser User { get; set; }  //object of type private user
        public Guid SpotID { get; set; }
        public ParkingSpot Spot { get; set; } //object of type Parking Spot
        [HiddenInput(DisplayValue = false)]    //we dont want the user to edit this property
        [DataType(DataType.Date)]
        public DateTime CreatedOn { get; set; } //date only
        [DataType(DataType.Date)]
        public DateTime ReservationDate { get; set; } //date only
        [Range(0, 23, ErrorMessage = "The value must be greater than 0 and lower then 24")]
        public int ReservationHour { get; set; } //between 0-23
        [Range(1, 2, ErrorMessage = "The value must be greater than 1 and lower then 2")]
        public int Duration { get; set; } //1/2
        public string carNumber { get; set; }
    }
}
