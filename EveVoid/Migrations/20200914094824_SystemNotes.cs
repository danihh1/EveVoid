using Microsoft.EntityFrameworkCore.Migrations;

namespace EveVoid.Migrations
{
    public partial class SystemNotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SolarSystemNote_MainCharacters_MainCharacterId",
                table: "SolarSystemNote");

            migrationBuilder.DropForeignKey(
                name: "FK_SolarSystemNote_Masks_MaskId",
                table: "SolarSystemNote");

            migrationBuilder.DropForeignKey(
                name: "FK_SolarSystemNote_SolarSystems_SolarSystemId",
                table: "SolarSystemNote");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SolarSystemNote",
                table: "SolarSystemNote");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "SolarSystemNote");

            migrationBuilder.RenameTable(
                name: "SolarSystemNote",
                newName: "SolarSystemNotes");

            migrationBuilder.RenameIndex(
                name: "IX_SolarSystemNote_SolarSystemId",
                table: "SolarSystemNotes",
                newName: "IX_SolarSystemNotes_SolarSystemId");

            migrationBuilder.RenameIndex(
                name: "IX_SolarSystemNote_MaskId",
                table: "SolarSystemNotes",
                newName: "IX_SolarSystemNotes_MaskId");

            migrationBuilder.RenameIndex(
                name: "IX_SolarSystemNote_MainCharacterId",
                table: "SolarSystemNotes",
                newName: "IX_SolarSystemNotes_MainCharacterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SolarSystemNotes",
                table: "SolarSystemNotes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SolarSystemNotes_MainCharacters_MainCharacterId",
                table: "SolarSystemNotes",
                column: "MainCharacterId",
                principalTable: "MainCharacters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SolarSystemNotes_Masks_MaskId",
                table: "SolarSystemNotes",
                column: "MaskId",
                principalTable: "Masks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SolarSystemNotes_SolarSystems_SolarSystemId",
                table: "SolarSystemNotes",
                column: "SolarSystemId",
                principalTable: "SolarSystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SolarSystemNotes_MainCharacters_MainCharacterId",
                table: "SolarSystemNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_SolarSystemNotes_Masks_MaskId",
                table: "SolarSystemNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_SolarSystemNotes_SolarSystems_SolarSystemId",
                table: "SolarSystemNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SolarSystemNotes",
                table: "SolarSystemNotes");

            migrationBuilder.RenameTable(
                name: "SolarSystemNotes",
                newName: "SolarSystemNote");

            migrationBuilder.RenameIndex(
                name: "IX_SolarSystemNotes_SolarSystemId",
                table: "SolarSystemNote",
                newName: "IX_SolarSystemNote_SolarSystemId");

            migrationBuilder.RenameIndex(
                name: "IX_SolarSystemNotes_MaskId",
                table: "SolarSystemNote",
                newName: "IX_SolarSystemNote_MaskId");

            migrationBuilder.RenameIndex(
                name: "IX_SolarSystemNotes_MainCharacterId",
                table: "SolarSystemNote",
                newName: "IX_SolarSystemNote_MainCharacterId");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "SolarSystemNote",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SolarSystemNote",
                table: "SolarSystemNote",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SolarSystemNote_MainCharacters_MainCharacterId",
                table: "SolarSystemNote",
                column: "MainCharacterId",
                principalTable: "MainCharacters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SolarSystemNote_Masks_MaskId",
                table: "SolarSystemNote",
                column: "MaskId",
                principalTable: "Masks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SolarSystemNote_SolarSystems_SolarSystemId",
                table: "SolarSystemNote",
                column: "SolarSystemId",
                principalTable: "SolarSystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
