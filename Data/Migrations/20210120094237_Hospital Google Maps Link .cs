using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalBedTracker.Data.Migrations
{
    public partial class HospitalGoogleMapsLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GoogleMapsLink",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoogleMapsLink",
                table: "AspNetUsers");
        }
    }
}
