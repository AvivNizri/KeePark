using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KeePark.Models
{
    public class KeeParkContext : DbContext
    {
        public KeeParkContext(DbContextOptions<KeeParkContext> options)
            : base(options)
        {
        }

        public DbSet<KeePark.Models.ParkingSpot> ParkingSpot { get; set; }
    }
}