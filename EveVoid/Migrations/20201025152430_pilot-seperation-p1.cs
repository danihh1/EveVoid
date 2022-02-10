using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EveVoid.Migrations
{
    public partial class pilotseperationp1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"delete from MainCharacters");

            migrationBuilder.DropForeignKey(
                name: "FK_EsiCharacters_Corporations_CorporationId",
                table: "EsiCharacters");

            migrationBuilder.DropForeignKey(
                name: "FK_EsiCharacters_MainCharacters_MainCharacterId",
                table: "EsiCharacters");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteSystem_MainCharacters_MainCharacterId",
                table: "FavoriteSystem");

            migrationBuilder.DropForeignKey(
                name: "FK_Jumps_EsiCharacters_EsiCharacterId",
                table: "Jumps");

            migrationBuilder.DropForeignKey(
                name: "FK_MapLayouts_MainCharacters_MainCharacterId",
                table: "MapLayouts");

            migrationBuilder.DropForeignKey(
                name: "FK_SolarSystemNotes_MainCharacters_MainCharacterId",
                table: "SolarSystemNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_StargateJumps_EsiCharacters_EsiCharacterId",
                table: "StargateJumps");

            migrationBuilder.DropIndex(
                name: "IX_StargateJumps_EsiCharacterId",
                table: "StargateJumps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MainCharacters",
                table: "MainCharacters");

            migrationBuilder.DropIndex(
                name: "IX_Jumps_EsiCharacterId",
                table: "Jumps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EsiCharacters",
                table: "EsiCharacters");

            migrationBuilder.DropIndex(
                name: "IX_EsiCharacters_CorporationId",
                table: "EsiCharacters");

            migrationBuilder.DropColumn(
                name: "EsiCharacterId",
                table: "StargateJumps");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MainCharacters");

            migrationBuilder.DropColumn(
                name: "GateCount",
                table: "MainCharacters");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "MainCharacters");

            migrationBuilder.DropColumn(
                name: "Orientation",
                table: "MainCharacters");

            migrationBuilder.DropColumn(
                name: "EsiCharacterId",
                table: "Jumps");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EsiCharacters");

            migrationBuilder.DropColumn(
                name: "CorporationId",
                table: "EsiCharacters");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "EsiCharacters");

            migrationBuilder.AddColumn<int>(
                name: "PilotId",
                table: "StargateJumps",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Idx",
                table: "MainCharacters",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "PilotId",
                table: "MainCharacters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PilotId",
                table: "Jumps",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Idx",
                table: "EsiCharacters",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "PilotId",
                table: "EsiCharacters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MainCharacters",
                table: "MainCharacters",
                column: "Idx");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EsiCharacters",
                table: "EsiCharacters",
                column: "Idx");

            migrationBuilder.CreateTable(
                name: "Pilots",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CorporationId = table.Column<int>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pilots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pilots_Corporations_CorporationId",
                        column: x => x.CorporationId,
                        principalTable: "Corporations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StargateJumps_PilotId",
                table: "StargateJumps",
                column: "PilotId");

            migrationBuilder.CreateIndex(
                name: "IX_MainCharacters_PilotId",
                table: "MainCharacters",
                column: "PilotId");

            migrationBuilder.CreateIndex(
                name: "IX_Jumps_PilotId",
                table: "Jumps",
                column: "PilotId");

            migrationBuilder.CreateIndex(
                name: "IX_EsiCharacters_PilotId",
                table: "EsiCharacters",
                column: "PilotId");

            migrationBuilder.CreateIndex(
                name: "IX_Pilots_CorporationId",
                table: "Pilots",
                column: "CorporationId");

            migrationBuilder.AddForeignKey(
                name: "FK_EsiCharacters_MainCharacters_MainCharacterId",
                table: "EsiCharacters",
                column: "MainCharacterId",
                principalTable: "MainCharacters",
                principalColumn: "Idx",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EsiCharacters_Pilots_PilotId",
                table: "EsiCharacters",
                column: "PilotId",
                principalTable: "Pilots",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteSystem_MainCharacters_MainCharacterId",
                table: "FavoriteSystem",
                column: "MainCharacterId",
                principalTable: "MainCharacters",
                principalColumn: "Idx",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jumps_Pilots_PilotId",
                table: "Jumps",
                column: "PilotId",
                principalTable: "Pilots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MainCharacters_Pilots_PilotId",
                table: "MainCharacters",
                column: "PilotId",
                principalTable: "Pilots",
                principalColumn: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_StargateJumps_Pilots_PilotId",
                table: "StargateJumps",
                column: "PilotId",
                principalTable: "Pilots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EsiCharacters_MainCharacters_MainCharacterId",
                table: "EsiCharacters");

            migrationBuilder.DropForeignKey(
                name: "FK_EsiCharacters_Pilots_PilotId",
                table: "EsiCharacters");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteSystem_MainCharacters_MainCharacterId",
                table: "FavoriteSystem");

            migrationBuilder.DropForeignKey(
                name: "FK_Jumps_Pilots_PilotId",
                table: "Jumps");

            migrationBuilder.DropForeignKey(
                name: "FK_MainCharacters_Pilots_PilotId",
                table: "MainCharacters");

            migrationBuilder.DropForeignKey(
                name: "FK_MapLayouts_MainCharacters_MainCharacterId",
                table: "MapLayouts");

            migrationBuilder.DropForeignKey(
                name: "FK_SolarSystemNotes_MainCharacters_MainCharacterId",
                table: "SolarSystemNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_StargateJumps_Pilots_PilotId",
                table: "StargateJumps");

            migrationBuilder.DropTable(
                name: "Pilots");

            migrationBuilder.DropIndex(
                name: "IX_StargateJumps_PilotId",
                table: "StargateJumps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MainCharacters",
                table: "MainCharacters");

            migrationBuilder.DropIndex(
                name: "IX_MainCharacters_PilotId",
                table: "MainCharacters");

            migrationBuilder.DropIndex(
                name: "IX_Jumps_PilotId",
                table: "Jumps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EsiCharacters",
                table: "EsiCharacters");

            migrationBuilder.DropIndex(
                name: "IX_EsiCharacters_PilotId",
                table: "EsiCharacters");

            migrationBuilder.DropColumn(
                name: "PilotId",
                table: "StargateJumps");

            migrationBuilder.DropColumn(
                name: "Idx",
                table: "MainCharacters");

            migrationBuilder.DropColumn(
                name: "PilotId",
                table: "MainCharacters");

            migrationBuilder.DropColumn(
                name: "PilotId",
                table: "Jumps");

            migrationBuilder.DropColumn(
                name: "Idx",
                table: "EsiCharacters");

            migrationBuilder.DropColumn(
                name: "PilotId",
                table: "EsiCharacters");

            migrationBuilder.AddColumn<int>(
                name: "EsiCharacterId",
                table: "StargateJumps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "MainCharacters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GateCount",
                table: "MainCharacters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MainCharacters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Orientation",
                table: "MainCharacters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EsiCharacterId",
                table: "Jumps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "EsiCharacters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CorporationId",
                table: "EsiCharacters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "EsiCharacters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MainCharacters",
                table: "MainCharacters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EsiCharacters",
                table: "EsiCharacters",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StargateJumps_EsiCharacterId",
                table: "StargateJumps",
                column: "EsiCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Jumps_EsiCharacterId",
                table: "Jumps",
                column: "EsiCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_EsiCharacters_CorporationId",
                table: "EsiCharacters",
                column: "CorporationId");

            migrationBuilder.AddForeignKey(
                name: "FK_EsiCharacters_Corporations_CorporationId",
                table: "EsiCharacters",
                column: "CorporationId",
                principalTable: "Corporations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Jumps_EsiCharacters_EsiCharacterId",
                table: "Jumps",
                column: "EsiCharacterId",
                principalTable: "EsiCharacters",
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

            migrationBuilder.AddForeignKey(
                name: "FK_StargateJumps_EsiCharacters_EsiCharacterId",
                table: "StargateJumps",
                column: "EsiCharacterId",
                principalTable: "EsiCharacters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
