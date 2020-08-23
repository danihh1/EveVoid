using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EveVoid.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alliances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alliances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ships",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Mass = table.Column<double>(nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Corporations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    AllianceId = table.Column<int>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corporations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Corporations_Alliances_AllianceId",
                        column: x => x.AllianceId,
                        principalTable: "Alliances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Constellaions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constellaions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Constellaions_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WormholeTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    MaxMass = table.Column<double>(nullable: false),
                    MaxJump = table.Column<double>(nullable: false),
                    LeadsToId = table.Column<int>(nullable: false),
                    Duration = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WormholeTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WormholeTypes_SystemTypes_LeadsToId",
                        column: x => x.LeadsToId,
                        principalTable: "SystemTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MainCharacters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CorporationId = table.Column<int>(nullable: true),
                    AccessToken = table.Column<string>(nullable: true),
                    RefreshToken = table.Column<string>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCharacters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainCharacters_Corporations_CorporationId",
                        column: x => x.CorporationId,
                        principalTable: "Corporations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SolarSystems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Class = table.Column<int>(nullable: false),
                    SystemTypeId = table.Column<int>(nullable: false),
                    ConstellaionId = table.Column<int>(nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolarSystems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolarSystems_Constellaions_ConstellaionId",
                        column: x => x.ConstellaionId,
                        principalTable: "Constellaions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolarSystems_SystemTypes_SystemTypeId",
                        column: x => x.SystemTypeId,
                        principalTable: "SystemTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EsiCharacters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CorporationId = table.Column<int>(nullable: true),
                    AccessToken = table.Column<string>(nullable: true),
                    RefreshToken = table.Column<string>(nullable: true),
                    MainCharacterId = table.Column<int>(nullable: false),
                    CurrentSystemId = table.Column<int>(nullable: true),
                    CurrentShipTypeId = table.Column<int>(nullable: true),
                    CurrentShipName = table.Column<string>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    TokenExpiresIn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EsiCharacters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EsiCharacters_Corporations_CorporationId",
                        column: x => x.CorporationId,
                        principalTable: "Corporations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EsiCharacters_Ships_CurrentShipTypeId",
                        column: x => x.CurrentShipTypeId,
                        principalTable: "Ships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EsiCharacters_SolarSystems_CurrentSystemId",
                        column: x => x.CurrentSystemId,
                        principalTable: "SolarSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EsiCharacters_MainCharacters_MainCharacterId",
                        column: x => x.MainCharacterId,
                        principalTable: "MainCharacters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Signatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SignatureId = table.Column<string>(nullable: true),
                    SystemId = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false),
                    SignatureType = table.Column<int>(nullable: false),
                    LeadsToId = table.Column<int>(nullable: true),
                    TypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Signatures_Signatures_LeadsToId",
                        column: x => x.LeadsToId,
                        principalTable: "Signatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Signatures_SolarSystems_SystemId",
                        column: x => x.SystemId,
                        principalTable: "SolarSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Signatures_WormholeTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "WormholeTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Stargates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    SystemId = table.Column<int>(nullable: false),
                    DestinationId = table.Column<int>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stargates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stargates_Stargates_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Stargates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stargates_SolarSystems_SystemId",
                        column: x => x.SystemId,
                        principalTable: "SolarSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WormholeStatics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SystemId = table.Column<int>(nullable: false),
                    WormholeTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WormholeStatics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WormholeStatics_SolarSystems_SystemId",
                        column: x => x.SystemId,
                        principalTable: "SolarSystems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WormholeStatics_WormholeTypes_WormholeTypeId",
                        column: x => x.WormholeTypeId,
                        principalTable: "WormholeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jumps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShipId = table.Column<int>(nullable: false),
                    WormholeId = table.Column<int>(nullable: false),
                    EsiCharacterId = table.Column<int>(nullable: false),
                    JumpDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jumps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jumps_EsiCharacters_EsiCharacterId",
                        column: x => x.EsiCharacterId,
                        principalTable: "EsiCharacters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jumps_Ships_ShipId",
                        column: x => x.ShipId,
                        principalTable: "Ships",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Jumps_Signatures_WormholeId",
                        column: x => x.WormholeId,
                        principalTable: "Signatures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StargateJumps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShipId = table.Column<int>(nullable: false),
                    StargateId = table.Column<int>(nullable: false),
                    EsiCharacterId = table.Column<int>(nullable: false),
                    JumpDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StargateJumps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StargateJumps_EsiCharacters_EsiCharacterId",
                        column: x => x.EsiCharacterId,
                        principalTable: "EsiCharacters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StargateJumps_Ships_ShipId",
                        column: x => x.ShipId,
                        principalTable: "Ships",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StargateJumps_Stargates_StargateId",
                        column: x => x.StargateId,
                        principalTable: "Stargates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Constellaions_RegionId",
                table: "Constellaions",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Corporations_AllianceId",
                table: "Corporations",
                column: "AllianceId");

            migrationBuilder.CreateIndex(
                name: "IX_EsiCharacters_CorporationId",
                table: "EsiCharacters",
                column: "CorporationId");

            migrationBuilder.CreateIndex(
                name: "IX_EsiCharacters_CurrentShipTypeId",
                table: "EsiCharacters",
                column: "CurrentShipTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EsiCharacters_CurrentSystemId",
                table: "EsiCharacters",
                column: "CurrentSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_EsiCharacters_MainCharacterId",
                table: "EsiCharacters",
                column: "MainCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Jumps_EsiCharacterId",
                table: "Jumps",
                column: "EsiCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Jumps_ShipId",
                table: "Jumps",
                column: "ShipId");

            migrationBuilder.CreateIndex(
                name: "IX_Jumps_WormholeId",
                table: "Jumps",
                column: "WormholeId");

            migrationBuilder.CreateIndex(
                name: "IX_MainCharacters_CorporationId",
                table: "MainCharacters",
                column: "CorporationId");

            migrationBuilder.CreateIndex(
                name: "IX_Signatures_LeadsToId",
                table: "Signatures",
                column: "LeadsToId");

            migrationBuilder.CreateIndex(
                name: "IX_Signatures_SystemId",
                table: "Signatures",
                column: "SystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Signatures_TypeId",
                table: "Signatures",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SolarSystems_ConstellaionId",
                table: "SolarSystems",
                column: "ConstellaionId");

            migrationBuilder.CreateIndex(
                name: "IX_SolarSystems_SystemTypeId",
                table: "SolarSystems",
                column: "SystemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StargateJumps_EsiCharacterId",
                table: "StargateJumps",
                column: "EsiCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_StargateJumps_ShipId",
                table: "StargateJumps",
                column: "ShipId");

            migrationBuilder.CreateIndex(
                name: "IX_StargateJumps_StargateId",
                table: "StargateJumps",
                column: "StargateId");

            migrationBuilder.CreateIndex(
                name: "IX_Stargates_DestinationId",
                table: "Stargates",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Stargates_SystemId",
                table: "Stargates",
                column: "SystemId");

            migrationBuilder.CreateIndex(
                name: "IX_WormholeStatics_SystemId",
                table: "WormholeStatics",
                column: "SystemId");

            migrationBuilder.CreateIndex(
                name: "IX_WormholeStatics_WormholeTypeId",
                table: "WormholeStatics",
                column: "WormholeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WormholeTypes_LeadsToId",
                table: "WormholeTypes",
                column: "LeadsToId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jumps");

            migrationBuilder.DropTable(
                name: "StargateJumps");

            migrationBuilder.DropTable(
                name: "WormholeStatics");

            migrationBuilder.DropTable(
                name: "Signatures");

            migrationBuilder.DropTable(
                name: "EsiCharacters");

            migrationBuilder.DropTable(
                name: "Stargates");

            migrationBuilder.DropTable(
                name: "WormholeTypes");

            migrationBuilder.DropTable(
                name: "Ships");

            migrationBuilder.DropTable(
                name: "MainCharacters");

            migrationBuilder.DropTable(
                name: "SolarSystems");

            migrationBuilder.DropTable(
                name: "Corporations");

            migrationBuilder.DropTable(
                name: "Constellaions");

            migrationBuilder.DropTable(
                name: "SystemTypes");

            migrationBuilder.DropTable(
                name: "Alliances");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
