using Microsoft.EntityFrameworkCore.Migrations;

namespace KeePark.Migrations
{
    public partial class FirstMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SiteType",
                table: "ParkingSpot",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SiteType",
                table: "ParkingSpot");
        }
    }
}
