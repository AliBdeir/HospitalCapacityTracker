using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalBedTracker.Data.Migrations
{
    public partial class HospitalImageandGoogleMapsURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GoogleMapsLink",
                table: "AspNetUsers",
                newName: "HospitalImageUrl");

            migrationBuilder.AddColumn<string>(
                name: "GoogleMapsUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoogleMapsUrl",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "HospitalImageUrl",
                table: "AspNetUsers",
                newName: "GoogleMapsLink");
        }
    }
}
