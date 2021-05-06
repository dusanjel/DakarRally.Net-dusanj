using Microsoft.EntityFrameworkCore.Migrations;

namespace DakarRally.NetDusanj.Migrations
{
    public partial class removeVehicleIdRace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Races");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "Races",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
