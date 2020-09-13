using EveVoid.Models.Navigation.MapObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Data.Mappings
{
    public class TagMap : IEntityBuilder<EveVoidContext>
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SolarSystemTag>()
                .HasOne(e => e.SolarSystem)
                .WithMany(e => e.Tags)
                .HasForeignKey(x => x.SolarSystemId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SolarSystemTag>()
                .HasOne(e => e.Mask)
                .WithMany()
                .HasForeignKey(x => x.MaskId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
