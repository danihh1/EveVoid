using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Dto
{
    public class EsiCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CorporationId { get; set; }
        public string CorporationName { get; set; }
        public int? AllianceId { get; set; }
        public string AllianceName { get; set; }
        public int? CurrentSystemId { get; set; }
        public string CurrentSystemName { get; set; }
        public int? CurrentShipTypeId { get; set; }
        public string CurrentShipTypeName { get; set; }
        public string CurrentShipName { get; set; }
        public string EsiToken { get; set; }
    }
}
