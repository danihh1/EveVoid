using EveVoid.Models.Navigation.Masks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Models.Navigation.Matrix
{
    public class AdjacencyMatrix
    {
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public int MaskId { get; set; }
        public int Distance { get; set; }

        public virtual Mask Mask { get; set; }
    }
}
