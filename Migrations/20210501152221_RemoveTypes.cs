using Microsoft.EntityFrameworkCore.Migrations;

namespace DakarRally.NetDusanj.Migrations
{
    public partial class RemoveTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MotorcycleType",
                table: "Motorcycles");

            migrationBuilder.DropColumn(
                name: "CarType",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "CarType",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MotorcycleType",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarType",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "MotorcycleType",
                table: "Vehicles");

            migrationBuilder.AddColumn<int>(
                name: "MotorcycleType",
                table: "Motorcycles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CarType",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
