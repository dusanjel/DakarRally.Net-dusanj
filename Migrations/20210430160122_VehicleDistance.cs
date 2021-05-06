using Microsoft.EntityFrameworkCore.Migrations;

namespace DakarRally.NetDusanj.Migrations
{
    public partial class VehicleDistance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Distance",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Distance",
                table: "Vehicles");
        }
    }
}
