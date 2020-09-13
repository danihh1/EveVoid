using Microsoft.EntityFrameworkCore.Migrations;

namespace EveVoid.Migrations
{
    public partial class ItemTypeId_SolarSysStruc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeName",
                table: "SolarSystemStructures");

            migrationBuilder.AddColumn<int>(
                name: "ItemTypeId",
                table: "SolarSystemStructures",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SolarSystemStructures_ItemTypeId",
                table: "SolarSystemStructures",
                column: "ItemTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SolarSystemStructures_ItemTypes_ItemTypeId",
                table: "SolarSystemStructures",
                column: "ItemTypeId",
                principalTable: "ItemTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SolarSystemStructures_ItemTypes_ItemTypeId",
                table: "SolarSystemStructures");

            migrationBuilder.DropIndex(
                name: "IX_SolarSystemStructures_ItemTypeId",
                table: "SolarSystemStructures");

            migrationBuilder.DropColumn(
                name: "ItemTypeId",
                table: "SolarSystemStructures");

            migrationBuilder.AddColumn<string>(
                name: "TypeName",
                table: "SolarSystemStructures",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
