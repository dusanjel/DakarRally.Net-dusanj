using Microsoft.EntityFrameworkCore.Migrations;

namespace DakarRally.Net_dusanj.Migrations
{
    public partial class VehicleRaceId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Races_RaceId",
                table: "Vehicles");

            migrationBuilder.AlterColumn<int>(
                name: "RaceId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Races_RaceId",
                table: "Vehicles",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "RaceId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Races_RaceId",
                table: "Vehicles");

            migrationBuilder.AlterColumn<int>(
                name: "RaceId",
                table: "Vehicles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Races_RaceId",
                table: "Vehicles",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "RaceId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
