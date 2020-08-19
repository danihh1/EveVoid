using EveVoid.Models.Navigation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Data.Mappings
{
    public class WormholeTypeMap : IEntityBuilder<EveVoidContext>
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WormholeStatic>()
                .HasOne(e => e.WormholeType)
                .WithMany(e => e.Statics)
                .HasForeignKey(e => e.WormholeTypeId);

            modelBuilder.Entity<WormholeType>()
                .HasOne(e => e.LeadsTo)
                .WithMany()
                .HasForeignKey(e => e.LeadsToId);
        }
    }
}
