using EveVoid.Models.Navigation.Matrix;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Data.Mappings
{
    public class MatrixMap : IEntityBuilder<EveVoidContext>
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdjacencyMatrix>().HasKey(x => new { x.RowNumber, x.ColumnNumber, x.MaskId });
            modelBuilder.Entity<AdjacencyMatrix>()
                .HasOne(e => e.Mask)
                .WithMany()
                .HasForeignKey(x => x.MaskId);
        }
    }
}
