using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KeePark.Models;

namespace KeePark.Models
{
    public class KeeParkContext : DbContext
    {
        public KeeParkContext(DbContextOptions<KeeParkContext> options)
            : base(options)
        {
        }

      /*  protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Data.GeneralUser>()
              .HasMany(p => p.Reservations)
              .WithOne()
              .HasForeignKey(pc => pc.UserID);
        }*/

        public DbSet<KeePark.Models.ParkingSpot> ParkingSpot { get; set; }

        public DbSet<KeePark.Models.ReserveSpot> ReserveSpot { get; set; }
    }
}