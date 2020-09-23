using EveVoid.Models.Navigation.MapObjects;
using Microsoft.EntityFrameworkCore;

namespace EveVoid.Data.Mappings
{
    public class DscanMap : IEntityBuilder<EveVoidContext>
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dscan>()
                .HasOne(x => x.Mask)
                .WithMany()
                .HasForeignKey(x => x.MaskId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Dscan>()
                .HasOne(x => x.SolarSystem)
                .WithMany(x => x.Dscans)
                .HasForeignKey(x => x.SolarSystemId);

            modelBuilder.Entity<DscanShip>()
                .HasOne(x => x.Dscan)
                .WithMany(x => x.DscanShips)
                .HasForeignKey(x => x.DscanId);

            modelBuilder.Entity<DscanShip>()
                .HasOne(x => x.ShipType)
                .WithMany()
                .HasForeignKey(x => x.ShipTypeId);
        }
    }
}
