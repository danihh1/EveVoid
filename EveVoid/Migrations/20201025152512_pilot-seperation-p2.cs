using Microsoft.EntityFrameworkCore.Migrations;

namespace EveVoid.Migrations
{
    public partial class pilotseperationp2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EsiCharacters_MainCharacters_MainCharacterId",
                table: "EsiCharacters");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteSystem_MainCharacters_MainCharacterId",
                table: "FavoriteSystem");

            migrationBuilder.DropForeignKey(
                name: "FK_MapLayouts_MainCharacters_MainCharacterId",
                table: "MapLayouts");

            migrationBuilder.DropForeignKey(
                name: "FK_SolarSystemNotes_MainCharacters_MainCharacterId",
                table: "SolarSystemNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MainCharacters",
                table: "MainCharacters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EsiCharacters",
                table: "EsiCharacters");

            migrationBuilder.DropColumn(
                name: "Idx",
                table: "MainCharacters");

            migrationBuilder.DropColumn(
                name: "Idx",
                table: "EsiCharacters");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "MainCharacters",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "EsiCharacters",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MainCharacters",
                table: "MainCharacters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EsiCharacters",
                table: "EsiCharacters",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EsiCharacters_MainCharacters_MainCharacterId",
                table: "EsiCharacters",
                column: "MainCharacterId",
                principalTable: "MainCharacters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteSystem_MainCharacters_MainCharacterId",
                table: "FavoriteSystem",
                column: "MainCharacterId",
                principalTable: "MainCharacters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MapLayouts_MainCharacters_MainCharacterId",
                table: "MapLayouts",
                column: "MainCharacterId",
                principalTable: "MainCharacters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SolarSystemNotes_MainCharacters_MainCharacterId",
                table: "SolarSystemNotes",
                column: "MainCharacterId",
                principalTable: "MainCharacters",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EsiCharacters_MainCharacters_MainCharacterId",
                table: "EsiCharacters");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteSystem_MainCharacters_MainCharacterId",
                table: "FavoriteSystem");

            migrationBuilder.DropForeignKey(
                name: "FK_MapLayouts_MainCharacters_MainCharacterId",
                table: "MapLayouts");

            migrationBuilder.DropForeignKey(
                name: "FK_SolarSystemNotes_MainCharacters_MainCharacterId",
                table: "SolarSystemNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MainCharacters",
                table: "MainCharacters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EsiCharacters",
                table: "EsiCharacters");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MainCharacters");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EsiCharacters");

            migrationBuilder.AddColumn<int>(
                name: "Idx",
                table: "MainCharacters",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Idx",
                table: "EsiCharacters",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MainCharacters",
                table: "MainCharacters",
                column: "Idx");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EsiCharacters",
                table: "EsiCharacters",
                column: "Idx");

            migrationBuilder.AddForeignKey(
                name: "FK_EsiCharacters_MainCharacters_MainCharacterId",
                table: "EsiCharacters",
                column: "MainCharacterId",
                principalTable: "MainCharacters",
                principalColumn: "Idx",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteSystem_MainCharacters_MainCharacterId",
                table: "FavoriteSystem",
                column: "MainCharacterId",
                principalTable: "MainCharacters",
                principalColumn: "Idx",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MapLayouts_MainCharacters_MainCharacterId",
                table: "MapLayouts",
                column: "MainCharacterId",
                principalTable: "MainCharacters",
                principalColumn: "Idx",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SolarSystemNotes_MainCharacters_MainCharacterId",
                table: "SolarSystemNotes",
                column: "MainCharacterId",
                principalTable: "MainCharacters",
                principalColumn: "Idx");
        }
    }
}
