using Microsoft.EntityFrameworkCore.Migrations;

namespace KeePark.Migrations
{
    public partial class UpdatedCreateSpot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "ParkingSpot",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "ParkingSpot",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpotDescription",
                table: "ParkingSpot",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpotName",
                table: "ParkingSpot",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "ParkingSpot");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "ParkingSpot");

            migrationBuilder.DropColumn(
                name: "SpotDescription",
                table: "ParkingSpot");

            migrationBuilder.DropColumn(
                name: "SpotName",
                table: "ParkingSpot");
        }
    }
}
