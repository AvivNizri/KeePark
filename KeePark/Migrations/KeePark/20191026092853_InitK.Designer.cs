﻿// <auto-generated />
using System;
using KeePark.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KeePark.Migrations.KeePark
{
    [DbContext(typeof(KeeParkContext))]
    [Migration("20191026092853_InitK")]
    partial class InitK
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KeePark.Models.ParkingSpot", b =>
                {
                    b.Property<int>("ParkingSpotID");

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int>("NunOfOrders");

                    b.Property<string>("OwnerID");

                    b.Property<int>("Price");

                    b.Property<string>("SpotDescription");

                    b.Property<string>("SpotName")
                        .IsRequired();

                    b.Property<string>("filePath");

                    b.HasKey("ParkingSpotID");

                    b.ToTable("ParkingSpot");
                });

            modelBuilder.Entity("KeePark.Models.ReserveSpot", b =>
                {
                    b.Property<Guid>("ReserveSpotID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("Duration");

                    b.Property<DateTime>("ReservationDate");

                    b.Property<int>("ReservationHour");

                    b.Property<int>("SpotID");

                    b.Property<string>("UserID");

                    b.Property<string>("carNumber");

                    b.HasKey("ReserveSpotID");

                    b.HasIndex("SpotID");

                    b.ToTable("ReserveSpot");
                });

            modelBuilder.Entity("KeePark.Models.ReserveSpot", b =>
                {
                    b.HasOne("KeePark.Models.ParkingSpot", "Spot")
                        .WithMany("SpotReservations")
                        .HasForeignKey("SpotID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
