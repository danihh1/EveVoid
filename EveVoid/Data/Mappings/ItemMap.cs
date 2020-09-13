using EveVoid.Models.EveObjects;
using Microsoft.EntityFrameworkCore;

namespace EveVoid.Data.Mappings
{
    public class ItemMap : IEntityBuilder<EveVoidContext>
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemType>()
                .HasOne(e => e.ItemGroup)
                .WithMany(e => e.ItemTypes)
                .HasForeignKey(x => x.ItemGroupId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ItemGroup>()
                .HasOne(e => e.ItemCategory)
                .WithMany(e => e.ItemGroups)
                .HasForeignKey(x => x.ItemCategoryId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
