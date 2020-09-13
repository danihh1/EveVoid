using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EveVoid.Migrations
{
    public partial class SystemStructures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SolarSystemStructures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TypeName = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    MaskId = table.Column<int>(nullable: false),
                    SolarSystemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolarSystemStructures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolarSystemStructures_Masks_MaskId",
                        column: x => x.MaskId,
                        principalTable: "Masks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolarSystemStructures_SolarSystems_SolarSystemId",
                        column: x => x.SolarSystemId,
                        principalTable: "SolarSystems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SolarSystemStructures_MaskId",
                table: "SolarSystemStructures",
                column: "MaskId");

            migrationBuilder.CreateIndex(
                name: "IX_SolarSystemStructures_SolarSystemId",
                table: "SolarSystemStructures",
                column: "SolarSystemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SolarSystemStructures");
        }
    }
}
