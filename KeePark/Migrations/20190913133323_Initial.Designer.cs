﻿// <auto-generated />
using System;
using KeePark.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KeePark.Migrations
{
    [DbContext(typeof(KeeParkContext))]
    [Migration("20190913133323_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KeepPark.Models.GeneralUser", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<double>("Balance");

                    b.Property<string>("CarNumber");

                    b.Property<string>("CarType");

                    b.Property<string>("CreditCard");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("ID");

                    b.ToTable("GeneralUser");
                });

            modelBuilder.Entity("KeepPark.Models.ParkingSpot", b =>
                {
                    b.Property<Guid>("ParkingSpotID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("SiteID");

                    b.Property<int>("X");

                    b.Property<int>("Y");

                    b.HasKey("ParkingSpotID");

                    b.HasIndex("SiteID");

                    b.ToTable("ParkingSpot");
                });

            modelBuilder.Entity("KeepPark.Models.ReserveSpot", b =>
                {
                    b.Property<Guid>("ReserveSpotID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("Duration");

                    b.Property<DateTime>("ReservationDate");

                    b.Property<int>("ReservationHour");

                    b.Property<Guid>("SpotID");

                    b.Property<string>("UserID");

                    b.HasKey("ReserveSpotID");

                    b.HasIndex("SpotID");

                    b.HasIndex("UserID");

                    b.ToTable("ReserveSpot");
                });

            modelBuilder.Entity("KeepPark.Models.Site", b =>
                {
                    b.Property<Guid>("SiteID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Label");

                    b.Property<string>("OwnerID");

                    b.Property<double>("PricePerHour");

                    b.Property<string>("SiteDescription");

                    b.Property<string>("SiteName");

                    b.Property<string>("SitePhoneNumber");

                    b.Property<string>("UserID");

                    b.HasKey("SiteID");

                    b.HasIndex("UserID");

                    b.ToTable("Site");
                });

            modelBuilder.Entity("KeepPark.Models.ParkingSpot", b =>
                {
                    b.HasOne("KeepPark.Models.Site")
                        .WithMany("ParkingSpots")
                        .HasForeignKey("SiteID");
                });

            modelBuilder.Entity("KeepPark.Models.ReserveSpot", b =>
                {
                    b.HasOne("KeepPark.Models.ParkingSpot", "Spot")
                        .WithMany()
                        .HasForeignKey("SpotID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KeepPark.Models.GeneralUser", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("KeepPark.Models.Site", b =>
                {
                    b.HasOne("KeepPark.Models.GeneralUser", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });
#pragma warning restore 612, 618
        }
    }
}
