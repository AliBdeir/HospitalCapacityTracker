using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalBedTracker.Data.Migrations
{
    public partial class UpdatedHospitalBedSectionstablename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hospitalBedSections_AspNetUsers_HospitalId1",
                table: "hospitalBedSections");

            migrationBuilder.DropForeignKey(
                name: "FK_hospitalBedSections_BedTypes_BedCategoryId",
                table: "hospitalBedSections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hospitalBedSections",
                table: "hospitalBedSections");

            migrationBuilder.RenameTable(
                name: "hospitalBedSections",
                newName: "HospitalBedSections");

            migrationBuilder.RenameIndex(
                name: "IX_hospitalBedSections_HospitalId1",
                table: "HospitalBedSections",
                newName: "IX_HospitalBedSections_HospitalId1");

            migrationBuilder.RenameIndex(
                name: "IX_hospitalBedSections_BedCategoryId",
                table: "HospitalBedSections",
                newName: "IX_HospitalBedSections_BedCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HospitalBedSections",
                table: "HospitalBedSections",
                column: "HospitalBedCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalBedSections_AspNetUsers_HospitalId1",
                table: "HospitalBedSections",
                column: "HospitalId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalBedSections_BedTypes_BedCategoryId",
                table: "HospitalBedSections",
                column: "BedCategoryId",
                principalTable: "BedTypes",
                principalColumn: "BedCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HospitalBedSections_AspNetUsers_HospitalId1",
                table: "HospitalBedSections");

            migrationBuilder.DropForeignKey(
                name: "FK_HospitalBedSections_BedTypes_BedCategoryId",
                table: "HospitalBedSections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HospitalBedSections",
                table: "HospitalBedSections");

            migrationBuilder.RenameTable(
                name: "HospitalBedSections",
                newName: "hospitalBedSections");

            migrationBuilder.RenameIndex(
                name: "IX_HospitalBedSections_HospitalId1",
                table: "hospitalBedSections",
                newName: "IX_hospitalBedSections_HospitalId1");

            migrationBuilder.RenameIndex(
                name: "IX_HospitalBedSections_BedCategoryId",
                table: "hospitalBedSections",
                newName: "IX_hospitalBedSections_BedCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hospitalBedSections",
                table: "hospitalBedSections",
                column: "HospitalBedCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_hospitalBedSections_AspNetUsers_HospitalId1",
                table: "hospitalBedSections",
                column: "HospitalId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_hospitalBedSections_BedTypes_BedCategoryId",
                table: "hospitalBedSections",
                column: "BedCategoryId",
                principalTable: "BedTypes",
                principalColumn: "BedCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
