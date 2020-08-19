﻿// <auto-generated />
using System;
using EveVoid.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EveVoid.Migrations
{
    [DbContext(typeof(EveVoidContext))]
    [Migration("20200818164128_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EveVoid.Models.EveObjects.Alliance", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Alliances");
                });

            modelBuilder.Entity("EveVoid.Models.EveObjects.Corporation", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("AllianceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AllianceId");

                    b.ToTable("Corporations");
                });

            modelBuilder.Entity("EveVoid.Models.EveObjects.Ship", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Mass")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ships");
                });

            modelBuilder.Entity("EveVoid.Models.Navigation.Jump", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EsiCharacterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("JumpDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ShipId")
                        .HasColumnType("int");

                    b.Property<int>("WormholeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EsiCharacterId");

                    b.HasIndex("ShipId");

                    b.HasIndex("WormholeId");

                    b.ToTable("Jumps");
                });

            modelBuilder.Entity("EveVoid.Models.Navigation.MapObjects.Constellation", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Constellaions");
                });

            modelBuilder.Entity("EveVoid.Models.Navigation.MapObjects.Region", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("EveVoid.Models.Navigation.MapObjects.SolarSystem", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("Class")
                        .HasColumnType("int");

                    b.Property<int>("ConstellaionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SystemTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConstellaionId");

                    b.HasIndex("SystemTypeId");

                    b.ToTable("SolarSystems");
                });

            modelBuilder.Entity("EveVoid.Models.Navigation.MapObjects.Stargate", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("DestinationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SystemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId");

                    b.HasIndex("SystemId");

                    b.ToTable("Stargates");
                });

            modelBuilder.Entity("EveVoid.Models.Navigation.MapObjects.SystemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SystemTypes");
                });

            modelBuilder.Entity("EveVoid.Models.Navigation.Signature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LeadsToId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SignatureId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SignatureType")
                        .HasColumnType("int");

                    b.Property<int>("SystemId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LeadsToId");

                    b.HasIndex("SystemId");

                    b.HasIndex("TypeId");

                    b.ToTable("Signatures");
                });

            modelBuilder.Entity("EveVoid.Models.Navigation.StargateJump", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EsiCharacterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("JumpDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ShipId")
                        .HasColumnType("int");

                    b.Property<int>("StargateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EsiCharacterId");

                    b.HasIndex("ShipId");

                    b.HasIndex("StargateId");

                    b.ToTable("StargateJumps");
                });

            modelBuilder.Entity("EveVoid.Models.Navigation.WormholeStatic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SystemId")
                        .HasColumnType("int");

                    b.Property<int>("WormholeTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SystemId");

                    b.HasIndex("WormholeTypeId");

                    b.ToTable("WormholeStatics");
                });

            modelBuilder.Entity("EveVoid.Models.Navigation.WormholeType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LeadsToId")
                        .HasColumnType("int");

                    b.Property<double>("MaxJump")
                        .HasColumnType("float");

                    b.Property<double>("MaxMass")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LeadsToId");

                    b.ToTable("WormholeTypes");
                });

            modelBuilder.Entity("EveVoid.Models.Pilots.EsiCharacter", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("AccessToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CorporationId")
                        .HasColumnType("int");

                    b.Property<int>("CurrentShipId")
                        .HasColumnType("int");

                    b.Property<int>("CurrentSystemId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MainCharacterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TokenExpiresIn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CorporationId");

                    b.HasIndex("CurrentShipId");

                    b.HasIndex("CurrentSystemId");

                    b.HasIndex("MainCharacterId");

                    b.ToTable("EsiCharacters");
                });

            modelBuilder.Entity("EveVoid.Models.Pilots.MainCharacter", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("AccessToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CorporationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CorporationId");

                    b.ToTable("MainCharacters");
                });

            modelBuilder.Entity("EveVoid.Models.EveObjects.Corporation", b =>
                {
                    b.HasOne("EveVoid.Models.EveObjects.Alliance", "Alliance")
                        .WithMany("Corporations")
                        .HasForeignKey("AllianceId");
                });

            modelBuilder.Entity("EveVoid.Models.Navigation.Jump", b =>
                {
                    b.HasOne("EveVoid.Models.Pilots.EsiCharacter", "EsiCharacter")
                        .WithMany("Jumps")
                        .HasForeignKey("EsiCharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EveVoid.Models.EveObjects.Ship", "Ship")
                        .WithMany()
                        .HasForeignKey("ShipId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("EveVoid.Models.Navigation.Signature", "Wormhole")
                        .WithMany("Jumps")
                        .HasForeignKey("WormholeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("EveVoid.Models.Navigation.MapObjects.Constellation", b =>
                {
                    b.HasOne("EveVoid.Models.Navigation.MapObjects.Region", "Region")
                        .WithMany("Constellaions")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EveVoid.Models.Navigation.MapObjects.SolarSystem", b =>
                {
                    b.HasOne("EveVoid.Models.Navigation.MapObjects.Constellation", "Constellaion")
                        .WithMany("SolarSystems")
                        .HasForeignKey("ConstellaionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EveVoid.Models.Navigation.MapObjects.SystemType", "SystemType")
                        .WithMany()
                        .HasForeignKey("SystemTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EveVoid.Models.Navigation.MapObjects.Stargate", b =>
                {
                    b.HasOne("EveVoid.Models.Navigation.MapObjects.Stargate", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationId");

                    b.HasOne("EveVoid.Models.Navigation.MapObjects.SolarSystem", "SolarSystem")
                        .WithMany("Gates")
                        .HasForeignKey("SystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EveVoid.Models.Navigation.Signature", b =>
                {
                    b.HasOne("EveVoid.Models.Navigation.Signature", "LeadsTo")
                        .WithMany()
                        .HasForeignKey("LeadsToId");

                    b.HasOne("EveVoid.Models.Navigation.MapObjects.SolarSystem", "System")
                        .WithMany("Signatures")
                        .HasForeignKey("SystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EveVoid.Models.Navigation.WormholeType", "WormholeType")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("EveVoid.Models.Navigation.StargateJump", b =>
                {
                    b.HasOne("EveVoid.Models.Pilots.EsiCharacter", "EsiCharacter")
                        .WithMany()
                        .HasForeignKey("EsiCharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EveVoid.Models.EveObjects.Ship", "Ship")
                        .WithMany()
                        .HasForeignKey("ShipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EveVoid.Models.Navigation.MapObjects.Stargate", "Stargate")
                        .WithMany("StargateJumps")
                        .HasForeignKey("StargateId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("EveVoid.Models.Navigation.WormholeStatic", b =>
                {
                    b.HasOne("EveVoid.Models.Navigation.MapObjects.SolarSystem", "SolarSystem")
                        .WithMany("Statics")
                        .HasForeignKey("SystemId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("EveVoid.Models.Navigation.WormholeType", "WormholeType")
                        .WithMany("Statics")
                        .HasForeignKey("WormholeTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EveVoid.Models.Navigation.WormholeType", b =>
                {
                    b.HasOne("EveVoid.Models.Navigation.MapObjects.SystemType", "LeadsTo")
                        .WithMany()
                        .HasForeignKey("LeadsToId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EveVoid.Models.Pilots.EsiCharacter", b =>
                {
                    b.HasOne("EveVoid.Models.EveObjects.Corporation", "Corporation")
                        .WithMany("EsiCharacters")
                        .HasForeignKey("CorporationId");

                    b.HasOne("EveVoid.Models.EveObjects.Ship", "CurrentShip")
                        .WithMany()
                        .HasForeignKey("CurrentShipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EveVoid.Models.Navigation.MapObjects.SolarSystem", "CurrentSystem")
                        .WithMany("Pilots")
                        .HasForeignKey("CurrentSystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EveVoid.Models.Pilots.MainCharacter", "MainCharacter")
                        .WithMany("EsiCharacters")
                        .HasForeignKey("MainCharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EveVoid.Models.Pilots.MainCharacter", b =>
                {
                    b.HasOne("EveVoid.Models.EveObjects.Corporation", "Corporation")
                        .WithMany("Mains")
                        .HasForeignKey("CorporationId");
                });
#pragma warning restore 612, 618
        }
    }
}
