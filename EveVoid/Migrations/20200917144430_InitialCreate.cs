using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using EveVoid.Data;
using EveVoid.Extensions;
using EveVoid.Models.Combine;
using EveVoid.Models.Navigation;
using EveVoid.Models.Navigation.MapObjects;
using EveVoid.Models.Navigation.Matrix;
using IO.Swagger.Api;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace EveVoid.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Constellations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constellations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Constellations_Regions_RegionId",
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

            migrationBuilder.CreateTable(
                name: "SolarSystems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Class = table.Column<int>(nullable: false),
                    Security = table.Column<double>(nullable: false),
                    SystemTypeId = table.Column<int>(nullable: false),
                    ConstellationId = table.Column<int>(nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    SystemEffect = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolarSystems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolarSystems_Constellations_ConstellationId",
                        column: x => x.ConstellationId,
                        principalTable: "Constellations",
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
                name: "Corporations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    AllianceId = table.Column<int>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    MaskId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corporations", x => x.Id);
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
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    MaskType = table.Column<int>(nullable: false),
                    GateCount = table.Column<int>(nullable: false),
                    Orientation = table.Column<string>(nullable: true)
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
                        name: "FK_EsiCharacters_ItemTypes_CurrentShipTypeId",
                        column: x => x.CurrentShipTypeId,
                        principalTable: "ItemTypes",
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
                name: "MapLayouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    MainCharacterId = table.Column<int>(nullable: false),
                    SolarSystemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapLayouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MapLayouts_MainCharacters_MainCharacterId",
                        column: x => x.MainCharacterId,
                        principalTable: "MainCharacters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MapLayouts_SolarSystems_SolarSystemId",
                        column: x => x.SolarSystemId,
                        principalTable: "SolarSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Masks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorporationId = table.Column<int>(nullable: true),
                    AllianceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Masks_Corporations_CorporationId",
                        column: x => x.CorporationId,
                        principalTable: "Corporations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdjacencyMatrix",
                columns: table => new
                {
                    RowNumber = table.Column<int>(nullable: false),
                    ColumnNumber = table.Column<int>(nullable: false),
                    MaskId = table.Column<int>(nullable: false),
                    Distance = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdjacencyMatrix", x => new { x.RowNumber, x.ColumnNumber, x.MaskId });
                    table.ForeignKey(
                        name: "FK_AdjacencyMatrix_Masks_MaskId",
                        column: x => x.MaskId,
                        principalTable: "Masks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alliances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    MaskId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alliances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alliances_Masks_MaskId",
                        column: x => x.MaskId,
                        principalTable: "Masks",
                        principalColumn: "Id");
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
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    SignatureType = table.Column<int>(nullable: false),
                    MaskId = table.Column<int>(nullable: false),
                    WormholeTypeId = table.Column<int>(nullable: true),
                    DestinationId = table.Column<int>(nullable: true),
                    MassIndicator = table.Column<int>(nullable: false),
                    TimeRemainingIndicator = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Signatures_Signatures_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Signatures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Signatures_Masks_MaskId",
                        column: x => x.MaskId,
                        principalTable: "Masks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Signatures_SolarSystems_SystemId",
                        column: x => x.SystemId,
                        principalTable: "SolarSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Signatures_WormholeTypes_WormholeTypeId",
                        column: x => x.WormholeTypeId,
                        principalTable: "WormholeTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SolarSystemNotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainCharacterId = table.Column<int>(nullable: false),
                    SolarSystemId = table.Column<int>(nullable: false),
                    MaskId = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolarSystemNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolarSystemNotes_MainCharacters_MainCharacterId",
                        column: x => x.MainCharacterId,
                        principalTable: "MainCharacters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SolarSystemNotes_Masks_MaskId",
                        column: x => x.MaskId,
                        principalTable: "Masks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolarSystemNotes_SolarSystems_SolarSystemId",
                        column: x => x.SolarSystemId,
                        principalTable: "SolarSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SolarSystemStructures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    ItemTypeId = table.Column<int>(nullable: false),
                    MaskId = table.Column<int>(nullable: false),
                    SolarSystemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolarSystemStructures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolarSystemStructures_ItemTypes_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemTypes",
                        principalColumn: "Id");
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

            migrationBuilder.CreateTable(
                name: "StargateJumps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShipId = table.Column<int>(nullable: false),
                    StargateId = table.Column<int>(nullable: false),
                    EsiCharacterId = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    MaskId = table.Column<int>(nullable: false)
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
                        name: "FK_StargateJumps_Masks_MaskId",
                        column: x => x.MaskId,
                        principalTable: "Masks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StargateJumps_ItemTypes_ShipId",
                        column: x => x.ShipId,
                        principalTable: "ItemTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StargateJumps_Stargates_StargateId",
                        column: x => x.StargateId,
                        principalTable: "Stargates",
                        principalColumn: "Id");
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
                    CreationDate = table.Column<DateTime>(nullable: false)
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
                        name: "FK_Jumps_ItemTypes_ShipId",
                        column: x => x.ShipId,
                        principalTable: "ItemTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Jumps_Signatures_WormholeId",
                        column: x => x.WormholeId,
                        principalTable: "Signatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Masks",
                columns: new[] { "Id", "AllianceId", "CorporationId" },
                values: new object[] { -1, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_AdjacencyMatrix_MaskId",
                table: "AdjacencyMatrix",
                column: "MaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Alliances_MaskId",
                table: "Alliances",
                column: "MaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Constellations_RegionId",
                table: "Constellations",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Corporations_AllianceId",
                table: "Corporations",
                column: "AllianceId");

            migrationBuilder.CreateIndex(
                name: "IX_Corporations_MaskId",
                table: "Corporations",
                column: "MaskId");

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
                name: "IX_FavoriteSystem_MainCharacterId",
                table: "FavoriteSystem",
                column: "MainCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteSystem_SolarSystemId",
                table: "FavoriteSystem",
                column: "SolarSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroups_ItemCategoryId",
                table: "ItemGroups",
                column: "ItemCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTypes_ItemGroupId",
                table: "ItemTypes",
                column: "ItemGroupId");

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
                name: "IX_MapLayouts_MainCharacterId",
                table: "MapLayouts",
                column: "MainCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_MapLayouts_SolarSystemId",
                table: "MapLayouts",
                column: "SolarSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Masks_AllianceId",
                table: "Masks",
                column: "AllianceId");

            migrationBuilder.CreateIndex(
                name: "IX_Masks_CorporationId",
                table: "Masks",
                column: "CorporationId");

            migrationBuilder.CreateIndex(
                name: "IX_Signatures_DestinationId",
                table: "Signatures",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Signatures_MaskId",
                table: "Signatures",
                column: "MaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Signatures_SystemId",
                table: "Signatures",
                column: "SystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Signatures_WormholeTypeId",
                table: "Signatures",
                column: "WormholeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SolarSystemNotes_MainCharacterId",
                table: "SolarSystemNotes",
                column: "MainCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_SolarSystemNotes_MaskId",
                table: "SolarSystemNotes",
                column: "MaskId");

            migrationBuilder.CreateIndex(
                name: "IX_SolarSystemNotes_SolarSystemId",
                table: "SolarSystemNotes",
                column: "SolarSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_SolarSystems_ConstellationId",
                table: "SolarSystems",
                column: "ConstellationId");

            migrationBuilder.CreateIndex(
                name: "IX_SolarSystems_SystemTypeId",
                table: "SolarSystems",
                column: "SystemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SolarSystemStructures_ItemTypeId",
                table: "SolarSystemStructures",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SolarSystemStructures_MaskId",
                table: "SolarSystemStructures",
                column: "MaskId");

            migrationBuilder.CreateIndex(
                name: "IX_SolarSystemStructures_SolarSystemId",
                table: "SolarSystemStructures",
                column: "SolarSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_SolarSystemTags_MaskId",
                table: "SolarSystemTags",
                column: "MaskId");

            migrationBuilder.CreateIndex(
                name: "IX_SolarSystemTags_SolarSystemId",
                table: "SolarSystemTags",
                column: "SolarSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_StargateJumps_EsiCharacterId",
                table: "StargateJumps",
                column: "EsiCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_StargateJumps_MaskId",
                table: "StargateJumps",
                column: "MaskId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Corporations_Masks_MaskId",
                table: "Corporations",
                column: "MaskId",
                principalTable: "Masks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Corporations_Alliances_AllianceId",
                table: "Corporations",
                column: "AllianceId",
                principalTable: "Alliances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Masks_Alliances_AllianceId",
                table: "Masks",
                column: "AllianceId",
                principalTable: "Alliances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alliances_Masks_MaskId",
                table: "Alliances");

            migrationBuilder.DropForeignKey(
                name: "FK_Corporations_Masks_MaskId",
                table: "Corporations");

            migrationBuilder.DropTable(
                name: "AdjacencyMatrix");

            migrationBuilder.DropTable(
                name: "FavoriteSystem");

            migrationBuilder.DropTable(
                name: "Jumps");

            migrationBuilder.DropTable(
                name: "MapLayouts");

            migrationBuilder.DropTable(
                name: "SolarSystemNotes");

            migrationBuilder.DropTable(
                name: "SolarSystemStructures");

            migrationBuilder.DropTable(
                name: "SolarSystemTags");

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
                name: "ItemTypes");

            migrationBuilder.DropTable(
                name: "MainCharacters");

            migrationBuilder.DropTable(
                name: "SolarSystems");

            migrationBuilder.DropTable(
                name: "ItemGroups");

            migrationBuilder.DropTable(
                name: "Constellations");

            migrationBuilder.DropTable(
                name: "SystemTypes");

            migrationBuilder.DropTable(
                name: "ItemCategories");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Masks");

            migrationBuilder.DropTable(
                name: "Corporations");

            migrationBuilder.DropTable(
                name: "Alliances");
        }
    }
}
