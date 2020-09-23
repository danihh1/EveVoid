using EveVoid.Models.Pilots;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EveVoid.Models.Navigation;
using EveVoid.Models.EveObjects;
using EveVoid.Data.Mappings;
using System.Reflection;
using EveVoid.Models.Navigation.MapObjects;
using EveVoid.Models.Shared;
using EveVoid.Models.Navigation.Masks;
using EveVoid.Models.Navigation.Matrix;

namespace EveVoid.Data
{
    public class EveVoidContext :DbContext
    {
        public EveVoidContext(DbContextOptions<EveVoidContext> options) : base(options)
        {

        }
        #region DbSets
        public DbSet<MainCharacter> MainCharacters { get; set; }
        public DbSet<EsiCharacter> EsiCharacters { get; set; }
        public DbSet<SolarSystem> SolarSystems { get; set; }
        public DbSet<Jump> Jumps { get; set; }
        public DbSet<Signature> Signatures { get; set; }
        public DbSet<Alliance> Alliances { get; set; }
        public DbSet<Corporation> Corporations { get; set; }
        public DbSet<WormholeType> WormholeTypes { get; set; }
        public DbSet<SystemType> SystemTypes { get; set; }
        public DbSet<WormholeStatic> WormholeStatics { get; set; }
        public DbSet<Stargate> Stargates { get; set; }
        public DbSet<StargateJump> StargateJumps { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Constellation> Constellations { get; set; }
        public DbSet<Mask> Masks { get; set; }
        public DbSet<MapLayout> MapLayouts { get; set; }
        public DbSet<SolarSystemTag> SolarSystemTags { get; set; }
        public DbSet<SolarSystemStructure> SolarSystemStructures { get; set; }
        public DbSet<SolarSystemNote> SolarSystemNotes { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<ItemGroup> ItemGroups { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<AdjacencyMatrix> AdjacencyMatrix { get; set; }
        public DbSet<Dscan> Dscans { get; set; }
        public DbSet<DscanShip> DscanShips { get; set; }
        
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Assembly.GetExecutingAssembly().GetTypes()
                .Where(x => x.GetInterfaces().Any(y => y.IsGenericType && y.Name == "IEntityBuilder`1"))
                 .Select(t => (IEntityBuilder<EveVoidContext>)Activator.CreateInstance(t))
                   .ToList()
                   .ForEach(t => t.Build(modelBuilder));
        }

        public override int SaveChanges()
        {
            this.ChangeTracker.DetectChanges();
            var added = this.ChangeTracker.Entries()
                .Where(t => t.State == EntityState.Added)
                .Select(t => t.Entity)
                .ToArray();

            foreach (var entity in added)
            {
                if (entity is IHasUpdateTime)
                {
                    var track = entity as IHasUpdateTime;
                    track.LastUpdate = DateTime.UtcNow;
                }
                if (entity is IHasCreationTime)
                {
                    var track = entity as IHasCreationTime;
                    track.CreationDate = DateTime.UtcNow;
                }
            }

            var modified = this.ChangeTracker.Entries()
                        .Where(t => t.State == EntityState.Modified)
                        .Select(t => t.Entity)
                        .ToArray();

            foreach (var entity in modified)
            {
                if (entity is IHasUpdateTime)
                {
                    var track = entity as IHasUpdateTime;
                    track.LastUpdate = DateTime.UtcNow;
                }
            }
            return base.SaveChanges();
        }
    }
}
