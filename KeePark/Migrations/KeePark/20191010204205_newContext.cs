using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KeePark.Migrations.KeePark
{
    public partial class newContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParkingSpot",
                columns: table => new
                {
                    ParkingSpotID = table.Column<Guid>(nullable: false),
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParkingSpot");
        }
    }
}
