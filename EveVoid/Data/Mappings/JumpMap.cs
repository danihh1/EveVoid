using EveVoid.Models.Navigation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Data.Mappings
{
    public class JumpMap : IEntityBuilder<EveVoidContext>
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jump>()
                .HasOne(x => x.Ship)
                .WithMany()
                .HasForeignKey(x => x.ShipId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Jump>()
                .HasOne(x => x.EsiCharacter)
                .WithMany(x => x.Jumps)
                .HasForeignKey(x => x.EsiCharacterId);
        }
    }
}
