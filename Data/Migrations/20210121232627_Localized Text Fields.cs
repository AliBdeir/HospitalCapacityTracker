using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalBedTracker.Data.Migrations
{
    public partial class LocalizedTextFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "BedTypes");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "HospitalImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GoogleMapsUrl",
                table: "AspNetUsers",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "BedTypeNames",
                columns: table => new
                {
                    LocalizedTextId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BedTypeId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    LanguageISO = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedTypeNames", x => x.LocalizedTextId);
                    table.ForeignKey(
                        name: "FK_BedTypeNames_BedTypes_BedTypeId",
                        column: x => x.BedTypeId,
                        principalTable: "BedTypes",
                        principalColumn: "BedCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HospitalAddresses",
                columns: table => new
                {
                    LocalizedTextId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    HospitalId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LanguageISO = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    HospitalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalAddresses", x => x.LocalizedTextId);
                    table.ForeignKey(
                        name: "FK_HospitalAddresses_AspNetUsers_HospitalId1",
                        column: x => x.HospitalId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HospitalNames",
                columns: table => new
                {
                    LocalizedTextId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    HospitalId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LanguageISO = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    HospitalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalNames", x => x.LocalizedTextId);
                    table.ForeignKey(
                        name: "FK_HospitalNames_AspNetUsers_HospitalId1",
                        column: x => x.HospitalId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BedTypeNames_BedTypeId",
                table: "BedTypeNames",
                column: "BedTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalAddresses_HospitalId1",
                table: "HospitalAddresses",
                column: "HospitalId1");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalNames_HospitalId1",
                table: "HospitalNames",
                column: "HospitalId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BedTypeNames");

            migrationBuilder.DropTable(
                name: "HospitalAddresses");

            migrationBuilder.DropTable(
                name: "HospitalNames");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BedTypes",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "HospitalImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GoogleMapsUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "");
        }
    }
}
