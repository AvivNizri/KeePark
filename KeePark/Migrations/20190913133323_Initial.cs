using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KeePark.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeneralUser",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    CreditCard = table.Column<string>(nullable: true),
                    CarNumber = table.Column<string>(nullable: true),
                    CarType = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Balance = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralUser", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Site",
                columns: table => new
                {
                    SiteID = table.Column<Guid>(nullable: false),
                    SiteName = table.Column<string>(nullable: true),
                    OwnerID = table.Column<string>(nullable: true),
                    UserID = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    SiteDescription = table.Column<string>(nullable: true),
                    SitePhoneNumber = table.Column<string>(nullable: true),
                    PricePerHour = table.Column<double>(nullable: false),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.SiteID);
                    table.ForeignKey(
                        name: "FK_Site_GeneralUser_UserID",
                        column: x => x.UserID,
                        principalTable: "GeneralUser",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParkingSpot",
                columns: table => new
                {
                    ParkingSpotID = table.Column<Guid>(nullable: false),
                    X = table.Column<int>(nullable: false),
                    Y = table.Column<int>(nullable: false),
                    SiteID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingSpot", x => x.ParkingSpotID);
                    table.ForeignKey(
                        name: "FK_ParkingSpot_Site_SiteID",
                        column: x => x.SiteID,
                        principalTable: "Site",
                        principalColumn: "SiteID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReserveSpot",
                columns: table => new
                {
                    ReserveSpotID = table.Column<Guid>(nullable: false),
                    UserID = table.Column<string>(nullable: true),
                    SpotID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ReservationDate = table.Column<DateTime>(nullable: false),
                    ReservationHour = table.Column<int>(nullable: false),
                    Duration = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReserveSpot", x => x.ReserveSpotID);
                    table.ForeignKey(
                        name: "FK_ReserveSpot_ParkingSpot_SpotID",
                        column: x => x.SpotID,
                        principalTable: "ParkingSpot",
                        principalColumn: "ParkingSpotID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReserveSpot_GeneralUser_UserID",
                        column: x => x.UserID,
                        principalTable: "GeneralUser",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParkingSpot_SiteID",
                table: "ParkingSpot",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_ReserveSpot_SpotID",
                table: "ReserveSpot",
                column: "SpotID");

            migrationBuilder.CreateIndex(
                name: "IX_ReserveSpot_UserID",
                table: "ReserveSpot",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Site_UserID",
                table: "Site",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReserveSpot");

            migrationBuilder.DropTable(
                name: "ParkingSpot");

            migrationBuilder.DropTable(
                name: "Site");

            migrationBuilder.DropTable(
                name: "GeneralUser");
        }
    }
}
