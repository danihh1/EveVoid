using EveVoid.Models.Navigation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Data.Mappings
{
    public class SignatureMap : IEntityBuilder<EveVoidContext>
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Signature>()
                .HasMany(x => x.Jumps)
                .WithOne(x => x.Wormhole)
                .HasForeignKey(x => x.WormholeId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Signature>()
                .HasOne(x => x.WormholeType)
                .WithMany()
                .HasForeignKey(x => x.WormholeTypeId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired(false);
            modelBuilder.Entity<Signature>()
                .HasOne(x => x.LeadsTo)
                .WithMany()
                .HasForeignKey(x => x.LeadsToId)
                .IsRequired(false);
            modelBuilder.Entity<Signature>()
                .HasOne(x => x.Mask)
                .WithMany()
                .HasForeignKey(x => x.MaskId);
        }
    }
}
