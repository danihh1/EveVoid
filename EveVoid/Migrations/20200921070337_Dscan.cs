using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EveVoid.Migrations
{
    public partial class Dscan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dscans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolarSystemId = table.Column<int>(nullable: false),
                    MaskId = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dscans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dscans_Masks_MaskId",
                        column: x => x.MaskId,
                        principalTable: "Masks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Dscans_SolarSystems_SolarSystemId",
                        column: x => x.SolarSystemId,
                        principalTable: "SolarSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DscanShips",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DscanId = table.Column<int>(nullable: false),
                    ShipTypeId = table.Column<int>(nullable: false),
                    ShipName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DscanShips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DscanShips_Dscans_DscanId",
                        column: x => x.DscanId,
                        principalTable: "Dscans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DscanShips_ItemTypes_ShipTypeId",
                        column: x => x.ShipTypeId,
                        principalTable: "ItemTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dscans_MaskId",
                table: "Dscans",
                column: "MaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Dscans_SolarSystemId",
                table: "Dscans",
                column: "SolarSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_DscanShips_DscanId",
                table: "DscanShips",
                column: "DscanId");

            migrationBuilder.CreateIndex(
                name: "IX_DscanShips_ShipTypeId",
                table: "DscanShips",
                column: "ShipTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DscanShips");

            migrationBuilder.DropTable(
                name: "Dscans");
        }
    }
}
