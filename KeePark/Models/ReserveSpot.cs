﻿using KeePark.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KeePark.Models
{
    public class ReserveSpot
    {   [Key]
        [HiddenInput]
        public Guid ReserveSpotID { get; set; }
        [ForeignKey("UserID")]
        public string UserID { get; set; }
        [ForeignKey("SpotID")]
        public int SpotID { get; set; }
        public virtual ParkingSpot Spot { get; set; } //object of type Parking Spot
        [HiddenInput]    //we dont want the user to edit this property
        [DataType(DataType.Date)]
        public DateTime CreatedOn { get; set; } //date only
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReservationDate { get; set; } //date only
        [Range(0, 23, ErrorMessage = "The value must be greater than 0 and lower then 24")]
        public int ReservationHour { get; set; } //between 0-23
        [Range(1, 3,  ErrorMessage = "The value must be greater than 1 an lower than 3")]
        public int Duration { get; set; } //1/2
        public string carNumber { get; set; }
    }
}
