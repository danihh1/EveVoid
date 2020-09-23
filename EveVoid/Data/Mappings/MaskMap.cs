using EveVoid.Models.EveObjects;
using EveVoid.Models.Navigation;
using Microsoft.EntityFrameworkCore;
using EveVoid.Models.Navigation.Masks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Data.Mappings
{
    public class MaskMap : IEntityBuilder<EveVoidContext>
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mask>().HasData(new Mask
            {
                Id = -1,
                AllianceId = null,
                CorporationId = null
            });

            modelBuilder.Entity<Mask>()
                  .HasOne(x => x.Corporation)
                  .WithMany()
                  .HasForeignKey(x => x.CorporationId)
                  .IsRequired(false);

            modelBuilder.Entity<Mask>()
                  .HasOne(x => x.Alliance)
                  .WithMany()
                  .HasForeignKey(x => x.AllianceId)
                  .IsRequired(false);

            modelBuilder.Entity<Corporation>()
                .HasOne(x => x.Mask)
                .WithMany()
                .HasForeignKey(x => x.MaskId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Alliance>()
                .HasOne(x => x.Mask)
                .WithMany()
                .HasForeignKey(x => x.MaskId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
