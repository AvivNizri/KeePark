using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KeePark.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KeePark.Models
{
    public class IdentityContext : IdentityDbContext<GeneralUser>
    {
        public IdentityContext()
        {
        }

        public IdentityContext(DbContextOptions<IdentityContext> options)
            : base(options)
        {
        }





        public DbSet<KeePark.Data.GeneralUser> GeneralUser { get; set; }

       /* protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

              builder.Entity<Data.GeneralUser>()
              .HasMany(p => p.Reservations)
              .WithOne()
              .HasForeignKey(u => u.User);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }*/


        
    }

}