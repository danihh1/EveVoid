using EveVoid.Models.Navigation;
using EveVoid.Models.Navigation.MapObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Data.Mappings
{
    public class StargateMap : IEntityBuilder<EveVoidContext>
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stargate>()
               .HasMany(x => x.StargateJumps)
               .WithOne(x => x.Stargate)
               .HasForeignKey(x => x.StargateId)
               .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<StargateJump>()
                .HasOne(x => x.Ship)
                .WithMany()
                .HasForeignKey(x => x.ShipId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Stargate>()
                .HasOne(x => x.Destination)
                .WithMany()
                .HasForeignKey(x => x.DestinationId);
            modelBuilder.Entity<Stargate>()
                .HasOne(x => x.SolarSystem)
                .WithMany(x => x.Gates)
                .HasForeignKey(x => x.SystemId);
        }
    }
}
