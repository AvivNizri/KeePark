using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KeePark.Migrations
{
    public partial class newUpdatedSystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeneralUser",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    UID = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    CreditCard = table.Column<string>(nullable: true),
                    CarNumber = table.Column<string>(nullable: true),
                    CarType = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Balance = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralUser", x => x.UID);
                });

            migrationBuilder.CreateTable(
                name: "ParkingSpot",
                columns: table => new
                {
                    ParkingSpotID = table.Column<int>(nullable: false),
                    SpotName = table.Column<string>(nullable: false),
                    OwnerID = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    NunOfOrders = table.Column<int>(nullable: false),
                    filePath = table.Column<string>(nullable: true),
                    SpotDescription = table.Column<string>(nullable: true)
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
                    SpotID = table.Column<int>(nullable: false),
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
                        name: "FK_ReserveSpot_GeneralUser_UserID",
                        column: x => x.UserID,
                        principalTable: "GeneralUser",
                        principalColumn: "UID",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReserveSpot");

            migrationBuilder.DropTable(
                name: "ParkingSpot");

            migrationBuilder.DropTable(
                name: "GeneralUser");
        }
    }
}
