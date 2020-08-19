using EveVoid.Models.EveObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Data.Mappings
{
    public class CorporationMap : IEntityBuilder<EveVoidContext>
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Corporation>()
                .HasOne(e => e.Alliance)
                .WithMany(e => e.Corporations)
                .HasForeignKey(x => x.AllianceId);

        }
    }
}
