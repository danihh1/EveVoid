using EveVoid.Models.Navigation;
using EveVoid.Models.Navigation.MapObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Data.Mappings
{
    public class SolarSystemMap : IEntityBuilder<EveVoidContext>
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SolarSystem>()
                .HasMany(e => e.Signatures)
                .WithOne(e => e.System)
                .HasForeignKey(e => e.SystemId);

            modelBuilder.Entity<SolarSystem>()
                .HasMany(e => e.Statics)
                .WithOne(e => e.SolarSystem)
                .HasForeignKey(e => e.SystemId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SolarSystem>()
                .HasOne(e => e.SystemType)
                .WithMany()
                .HasForeignKey(e => e.SystemTypeId);

            modelBuilder.Entity<SolarSystem>()
                .HasOne(e => e.Constellaion)
                .WithMany(e => e.SolarSystems)
                .HasForeignKey(e => e.ConstellaionId);
        }
    }
}
