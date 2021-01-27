using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalBedTracker.Data.Migrations
{
    public partial class UseStringGUIDinsteadofIDforhospital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HospitalAddresses_AspNetUsers_HospitalId1",
                table: "HospitalAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_HospitalBedSections_AspNetUsers_HospitalId1",
                table: "HospitalBedSections");

            migrationBuilder.DropForeignKey(
                name: "FK_HospitalNames_AspNetUsers_HospitalId1",
                table: "HospitalNames");

            migrationBuilder.DropIndex(
                name: "IX_HospitalNames_HospitalId1",
                table: "HospitalNames");

            migrationBuilder.DropIndex(
                name: "IX_HospitalBedSections_HospitalId1",
                table: "HospitalBedSections");

            migrationBuilder.DropIndex(
                name: "IX_HospitalAddresses_HospitalId1",
                table: "HospitalAddresses");

            migrationBuilder.DropColumn(
                name: "HospitalId1",
                table: "HospitalNames");

            migrationBuilder.DropColumn(
                name: "HospitalId1",
                table: "HospitalBedSections");

            migrationBuilder.DropColumn(
                name: "HospitalId1",
                table: "HospitalAddresses");

            migrationBuilder.AlterColumn<string>(
                name: "HospitalId",
                table: "HospitalNames",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "HospitalId",
                table: "HospitalBedSections",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "HospitalId",
                table: "HospitalAddresses",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalNames_HospitalId",
                table: "HospitalNames",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalBedSections_HospitalId",
                table: "HospitalBedSections",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalAddresses_HospitalId",
                table: "HospitalAddresses",
                column: "HospitalId");

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalAddresses_AspNetUsers_HospitalId",
                table: "HospitalAddresses",
                column: "HospitalId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalBedSections_AspNetUsers_HospitalId",
                table: "HospitalBedSections",
                column: "HospitalId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalNames_AspNetUsers_HospitalId",
                table: "HospitalNames",
                column: "HospitalId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HospitalAddresses_AspNetUsers_HospitalId",
                table: "HospitalAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_HospitalBedSections_AspNetUsers_HospitalId",
                table: "HospitalBedSections");

            migrationBuilder.DropForeignKey(
                name: "FK_HospitalNames_AspNetUsers_HospitalId",
                table: "HospitalNames");

            migrationBuilder.DropIndex(
                name: "IX_HospitalNames_HospitalId",
                table: "HospitalNames");

            migrationBuilder.DropIndex(
                name: "IX_HospitalBedSections_HospitalId",
                table: "HospitalBedSections");

            migrationBuilder.DropIndex(
                name: "IX_HospitalAddresses_HospitalId",
                table: "HospitalAddresses");

            migrationBuilder.AlterColumn<int>(
                name: "HospitalId",
                table: "HospitalNames",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HospitalId1",
                table: "HospitalNames",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HospitalId",
                table: "HospitalBedSections",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HospitalId1",
                table: "HospitalBedSections",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HospitalId",
                table: "HospitalAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HospitalId1",
                table: "HospitalAddresses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HospitalNames_HospitalId1",
                table: "HospitalNames",
                column: "HospitalId1");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalBedSections_HospitalId1",
                table: "HospitalBedSections",
                column: "HospitalId1");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalAddresses_HospitalId1",
                table: "HospitalAddresses",
                column: "HospitalId1");

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalAddresses_AspNetUsers_HospitalId1",
                table: "HospitalAddresses",
                column: "HospitalId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalBedSections_AspNetUsers_HospitalId1",
                table: "HospitalBedSections",
                column: "HospitalId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalNames_AspNetUsers_HospitalId1",
                table: "HospitalNames",
                column: "HospitalId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
