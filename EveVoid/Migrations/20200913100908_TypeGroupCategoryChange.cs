using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EveVoid.Migrations
{
    public partial class TypeGroupCategoryChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EsiCharacters_Ships_CurrentShipTypeId",
                table: "EsiCharacters");

            migrationBuilder.DropForeignKey(
                name: "FK_Jumps_Ships_ShipId",
                table: "Jumps");

            migrationBuilder.DropForeignKey(
                name: "FK_StargateJumps_Ships_ShipId",
                table: "StargateJumps");

            migrationBuilder.DropTable(
                name: "Ships");

            migrationBuilder.CreateTable(
                name: "ItemCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    ItemCategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemGroups_ItemCategories_ItemCategoryId",
                        column: x => x.ItemCategoryId,
                        principalTable: "ItemCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    ItemGroupId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Mass = table.Column<double>(nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemTypes_ItemGroups_ItemGroupId",
                        column: x => x.ItemGroupId,
                        principalTable: "ItemGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroups_ItemCategoryId",
                table: "ItemGroups",
                column: "ItemCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTypes_ItemGroupId",
                table: "ItemTypes",
                column: "ItemGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_EsiCharacters_ItemTypes_CurrentShipTypeId",
                table: "EsiCharacters",
                column: "CurrentShipTypeId",
                principalTable: "ItemTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jumps_ItemTypes_ShipId",
                table: "Jumps",
                column: "ShipId",
                principalTable: "ItemTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StargateJumps_ItemTypes_ShipId",
                table: "StargateJumps",
                column: "ShipId",
                principalTable: "ItemTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EsiCharacters_ItemTypes_CurrentShipTypeId",
                table: "EsiCharacters");

            migrationBuilder.DropForeignKey(
                name: "FK_Jumps_ItemTypes_ShipId",
                table: "Jumps");

            migrationBuilder.DropForeignKey(
                name: "FK_StargateJumps_ItemTypes_ShipId",
                table: "StargateJumps");

            migrationBuilder.DropTable(
                name: "ItemTypes");

            migrationBuilder.DropTable(
                name: "ItemGroups");

            migrationBuilder.DropTable(
                name: "ItemCategories");

            migrationBuilder.CreateTable(
                name: "Ships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mass = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ships", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_EsiCharacters_Ships_CurrentShipTypeId",
                table: "EsiCharacters",
                column: "CurrentShipTypeId",
                principalTable: "Ships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jumps_Ships_ShipId",
                table: "Jumps",
                column: "ShipId",
                principalTable: "Ships",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StargateJumps_Ships_ShipId",
                table: "StargateJumps",
                column: "ShipId",
                principalTable: "Ships",
                principalColumn: "Id");
        }
    }
}
