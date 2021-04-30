using Microsoft.EntityFrameworkCore.Migrations;

namespace DakarRally.Net_dusanj.Migrations
{
    public partial class AddWinner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Winner",
                table: "Vehicles",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Winner",
                table: "Vehicles");
        }
    }
}
