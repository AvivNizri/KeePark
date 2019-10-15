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
    [Migration("20191013173207_common")]
    partial class common
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KeePark.Data.GeneralUser", b =>
                {
                    b.Property<string>("UID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address");

                    b.Property<double>("Balance");

                    b.Property<string>("CarNumber");

                    b.Property<string>("CarType");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("CreditCard");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("Id");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("UID");

                    b.ToTable("GeneralUser");
                });

            modelBuilder.Entity("KeePark.Models.ParkingSpot", b =>
                {
                    b.Property<Guid>("ParkingSpotID")
                        .ValueGeneratedOnAdd();

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

                    b.Property<Guid>("SpotID");

                    b.Property<string>("UserID");

                    b.Property<string>("carNumber");

                    b.HasKey("ReserveSpotID");

                    b.HasIndex("SpotID");

                    b.HasIndex("UserID");

                    b.ToTable("ReserveSpot");
                });

            modelBuilder.Entity("KeePark.Models.ReserveSpot", b =>
                {
                    b.HasOne("KeePark.Models.ParkingSpot", "Spot")
                        .WithMany()
                        .HasForeignKey("SpotID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KeePark.Data.GeneralUser", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserID");
                });
#pragma warning restore 612, 618
        }
    }
}