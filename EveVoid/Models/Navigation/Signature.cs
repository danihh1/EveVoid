using EveVoid.Models.Navigation.MapObjects;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using EveVoid.Models.Navigation.Masks;
using EveVoid.Models.Shared;
using System.Collections.Generic;

namespace EveVoid.Models.Navigation
{
    public class Signature: IMasked, IHasUpdateTime, IHasCreationTime, IHasExpiry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SignatureId { get; set; }
        public int SystemId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public SignatureType SignatureType { get; set; }
        public int MaskId { get; set; }

        public virtual SolarSystem System { get; set; }
        public virtual Mask Mask { get; set; }

        //wormhole
        public int? WormholeTypeId { get; set; }
        public int? DestinationId { get; set; }
        public MassIndicator MassIndicator { get; set; }

        public TimeRemainingIndicator TimeRemainingIndicator { get; set; }

        public virtual WormholeType WormholeType { get; set; }
        public virtual List<Jump> Jumps { get; set; }
        public virtual Signature Destination { get; set; }

        //public bool IsEntrance { get; set; }
        //{
        //    get
        //    {
        //        return WormholeTypeId != null && WormholeType.LeadsTo.Name != "Unknown";
        //    }
        //}

        public Signature()
        {
            MassIndicator = MassIndicator.Unset;
            TimeRemainingIndicator = TimeRemainingIndicator.Unset;
            //WormholeTypeId = 1;
            Jumps = new List<Jump>();
        }
    }
}
