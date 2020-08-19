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
                .HasOne(e => e.Corporation)
                .WithMany(e => e.Mains)
                .HasForeignKey(x => x.CorporationId);

            modelBuilder.Entity<EsiCharacter>()
                .HasOne(e => e.Corporation)
                .WithMany(e => e.EsiCharacters)
                .HasForeignKey(x => x.CorporationId);

            modelBuilder.Entity<EsiCharacter>()
                .HasOne(e => e.CurrentSystem)
                .WithMany(e => e.Pilots)
                .HasForeignKey(x => x.CurrentSystemId);

            modelBuilder.Entity<EsiCharacter>()
                .HasOne(e => e.CurrentShip)
                .WithMany()
                .HasForeignKey(x => x.CurrentShipId);
        }
    }
}
