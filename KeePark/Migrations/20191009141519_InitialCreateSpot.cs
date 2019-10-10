using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KeePark.Migrations
{
    public partial class InitialCreateSpot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParkingSpot",
                columns: table => new
                {
                    ParkingSpotID = table.Column<Guid>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    NunOfOrders = table.Column<int>(nullable: false),
                    filePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingSpot", x => x.ParkingSpotID);
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
                    Duration = table.Column<int>(nullable: false),
                    carNumber = table.Column<string>(nullable: true)
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
                        name: "FK_ReserveSpot_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Site",
                columns: table => new
                {
                    SiteID = table.Column<Guid>(nullable: false),
                    SiteName = table.Column<string>(nullable: true),
                    OwnerID = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    ParkingSpotID = table.Column<Guid>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    SiteDescription = table.Column<string>(nullable: true),
                    SitePhoneNumber = table.Column<string>(nullable: true),
                    PricePerHour = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.SiteID);
                    table.ForeignKey(
                        name: "FK_Site_ParkingSpot_ParkingSpotID",
                        column: x => x.ParkingSpotID,
                        principalTable: "ParkingSpot",
                        principalColumn: "ParkingSpotID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Site_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReserveSpot_SpotID",
                table: "ReserveSpot",
                column: "SpotID");

            migrationBuilder.CreateIndex(
                name: "IX_ReserveSpot_UserID",
                table: "ReserveSpot",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Site_ParkingSpotID",
                table: "Site",
                column: "ParkingSpotID");

            migrationBuilder.CreateIndex(
                name: "IX_Site_UserId",
                table: "Site",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReserveSpot");

            migrationBuilder.DropTable(
                name: "Site");

            migrationBuilder.DropTable(
                name: "ParkingSpot");
        }
    }
}
