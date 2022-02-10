using EveVoid.Models.Pilots;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Data.Mappings
{
    public class CharacterMap : IEntityBuilder<EveVoidContext>
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MainCharacter>()
                .HasMany(e => e.EsiCharacters)
                .WithOne(e => e.MainCharacter)
                .HasForeignKey(x => x.MainCharacterId);

            modelBuilder.Entity<MainCharacter>()
                .HasOne(e => e.Pilot)
                .WithMany()
                .HasForeignKey(x => x.PilotId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<EsiCharacter>()
                .HasOne(e => e.Pilot)
                .WithMany()
                .HasForeignKey(x => x.PilotId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Pilot>()
                .HasOne(e => e.Corporation)
                .WithMany(e => e.Pilots)
                .HasForeignKey(x => x.CorporationId);

            modelBuilder.Entity<MainCharacter>()
                .HasMany(e => e.MapLayouts)
                .WithOne(e => e.MainCharacter)
                .HasForeignKey(x => x.MainCharacterId);

            modelBuilder.Entity<MainCharacter>()
                .HasMany(e => e.FavoriteSystems)
                .WithOne(e => e.MainCharacter)
                .HasForeignKey(x => x.MainCharacterId);

            modelBuilder.Entity<FavoriteSystem>()
                .HasOne(e => e.SolarSystem)
                .WithMany()
                .HasForeignKey(x => x.SolarSystemId);

            modelBuilder.Entity<MapLayout>()
                .HasOne(e => e.SolarSystem)
                .WithMany()
                .HasForeignKey(x => x.SolarSystemId);

            modelBuilder.Entity<EsiCharacter>()
                .HasOne(e => e.CurrentSystem)
                .WithMany(e => e.Pilots)
                .HasForeignKey(x => x.CurrentSystemId)
                .IsRequired(false);

            modelBuilder.Entity<EsiCharacter>()
                .HasOne(e => e.CurrentShip)
                .WithMany()
                .HasForeignKey(x => x.CurrentShipTypeId)
                .IsRequired(false);
        }
    }
}
