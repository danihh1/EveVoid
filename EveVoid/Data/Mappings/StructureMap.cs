using EveVoid.Models.Navigation.MapObjects;
using Microsoft.EntityFrameworkCore;

namespace EveVoid.Data.Mappings
{
    public class StructureMap : IEntityBuilder<EveVoidContext>
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SolarSystemStructure>()
                .HasOne(e => e.SolarSystem)
                .WithMany(e => e.Structures)
                .HasForeignKey(x => x.SolarSystemId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SolarSystemStructure>()
                .HasOne(e => e.Mask)
                .WithMany()
                .HasForeignKey(x => x.MaskId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SolarSystemStructure>()
                .HasOne(e => e.ItemType)
                .WithMany()
                .HasForeignKey(x => x.ItemTypeId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
