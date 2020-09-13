using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EveVoid.Migrations
{
    public partial class Tags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SolarSystemFlares");

            migrationBuilder.CreateTable(
                name: "FavoriteSystem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainCharacterId = table.Column<int>(nullable: false),
                    SolarSystemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteSystem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteSystem_MainCharacters_MainCharacterId",
                        column: x => x.MainCharacterId,
                        principalTable: "MainCharacters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteSystem_SolarSystems_SolarSystemId",
                        column: x => x.SolarSystemId,
                        principalTable: "SolarSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SolarSystemTags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    MaskId = table.Column<int>(nullable: false),
                    SolarSystemId = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolarSystemTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolarSystemTags_Masks_MaskId",
                        column: x => x.MaskId,
                        principalTable: "Masks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolarSystemTags_SolarSystems_SolarSystemId",
                        column: x => x.SolarSystemId,
                        principalTable: "SolarSystems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteSystem_MainCharacterId",
                table: "FavoriteSystem",
                column: "MainCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteSystem_SolarSystemId",
                table: "FavoriteSystem",
                column: "SolarSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_SolarSystemTags_MaskId",
                table: "SolarSystemTags",
                column: "MaskId");

            migrationBuilder.CreateIndex(
                name: "IX_SolarSystemTags_SolarSystemId",
                table: "SolarSystemTags",
                column: "SolarSystemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteSystem");

            migrationBuilder.DropTable(
                name: "SolarSystemTags");

            migrationBuilder.CreateTable(
                name: "SolarSystemFlares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaskId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolarSystemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolarSystemFlares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolarSystemFlares_Masks_MaskId",
                        column: x => x.MaskId,
                        principalTable: "Masks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolarSystemFlares_SolarSystems_SolarSystemId",
                        column: x => x.SolarSystemId,
                        principalTable: "SolarSystems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SolarSystemFlares_MaskId",
                table: "SolarSystemFlares",
                column: "MaskId");

            migrationBuilder.CreateIndex(
                name: "IX_SolarSystemFlares_SolarSystemId",
                table: "SolarSystemFlares",
                column: "SolarSystemId");
        }
    }
}
