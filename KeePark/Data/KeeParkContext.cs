using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KeepPark.Models;


namespace KeePark.Models
{
    public class KeeParkContext : DbContext
    {
        public KeeParkContext (DbContextOptions<KeeParkContext> options)
            : base(options)
        {
        }

        public DbSet<KeepPark.Models.GeneralUser> GeneralUser { get; set; }

        public DbSet<KeepPark.Models.ParkingSpot> ParkingSpot { get; set; }

        public DbSet<KeepPark.Models.ReserveSpot> ReserveSpot { get; set; }

        public DbSet<KeepPark.Models.Site> Site { get; set; }
       
    }

  
}
