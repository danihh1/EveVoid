using EveVoid.Models.Navigation.MapObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Dto
{
    public class SolarSystemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public double Security { get; set; }
        public Flare Flare { get; set; }
        public int SystemTypeId { get; set; }
        public int ConstellaionId { get; set; }
        public string ConstellaionName { get; set; }
        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public string SystemType { get; set; }
        public List<string> Statics { get; set; }
        public List<SignatureDto> Signatures { get; set; }
        public List<ActivePilotDto> Pilots { get; set; }
        public List<StargateDto> Gates { get; set; }
        public List<SolarSystemNoteDto> Notes { get; set; }

        public SolarSystemDto()
        {
            Statics = new List<string>();
            Signatures = new List<SignatureDto>();
            Pilots = new List<ActivePilotDto>();
            Gates = new List<StargateDto>();
            Notes = new List<SolarSystemNoteDto>();
        }
    }
}
