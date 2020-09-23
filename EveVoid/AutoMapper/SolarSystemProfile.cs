using AutoMapper;
using EveVoid.Dto;
using EveVoid.Models.Navigation;
using EveVoid.Models.Navigation.MapObjects;
using EveVoid.Models.Pilots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.AutoMapper
{
    public class SolarSystemProfile:Profile
    {
        public SolarSystemProfile()
        {
            CreateMap<SolarSystem, SolarSystemDto>()
                .ForMember(src => src.RegionId, dst => dst.MapFrom(x => x.Constellation.RegionId))
                .ForMember(src => src.RegionName, dst => dst.MapFrom(x => x.Constellation.Region.Name))
                .ForMember(src => src.Statics, dst => dst.MapFrom(x => x.Statics.Select(x => x.WormholeType.LeadsTo.Name).ToList()))
                .ForMember(src => src.Signatures, dst => dst.Ignore())
                .ForMember(src => src.Pilots, dst => dst.Ignore())
                .ForMember(src => src.Notes, dst => dst.Ignore())
                .ForMember(src => src.Tags, dst => dst.Ignore())
                .ForMember(src => src.Structures, dst => dst.Ignore())
                .ForMember(src => src.Dscans, dst => dst.Ignore());

            CreateMap<Signature, SignatureDto>()
                .ForMember(src => src.DestinationSystemId, dst => dst.MapFrom(x => x.Destination.SystemId))
                .ForMember(src => src.DestinationSystemName, dst => dst.MapFrom(x => x.Destination.System.Name))
                .ForMember(src => src.TotalMass, dst => dst.MapFrom(x => x.WormholeType == null ? 0 :
                    x.WormholeType.MaxJump <= 5000000 || (x.Destination != null && x.Destination.WormholeType.MaxJump <= 5000000) ? -1 :
                    x.MassIndicator == MassIndicator.VoC ?
                    Math.Max((x.Jumps.Sum(x => x.Ship.Mass) + (x.Destination == null ? 0 : x.Destination.Jumps.Sum(x => x.Ship.Mass))) / x.WormholeType.MaxMass , 0.9) :
                    x.MassIndicator == MassIndicator.Destab ?
                    Math.Max((x.Jumps.Sum(x => x.Ship.Mass) + (x.Destination == null ? 0 : x.Destination.Jumps.Sum(x => x.Ship.Mass))) / x.WormholeType.MaxMass, 0.5) :
                    (x.Jumps.Sum(x => x.Ship.Mass) + (x.Destination == null ? 0 : x.Destination.Jumps.Sum(x => x.Ship.Mass))) / x.WormholeType.MaxMass
                    ))
                .ForMember(src => src.WormholeType, dst => dst.MapFrom(x => x.WormholeType.Name))
                .ForMember(src => src.DestinationWormholeType, dst => dst.MapFrom(x => x.Destination.WormholeType.Name));

            CreateMap<EsiCharacter, ActivePilotDto>()
                .ForMember(src => src.ShipName, dst => dst.MapFrom(x => x.CurrentShipName))
                .ForMember(src => src.ShipTypeName, dst => dst.MapFrom(x => x.CurrentShip.Name));

            CreateMap<Stargate, StargateDto>()
                .ForMember(src => src.LeadsToId, dst => dst.MapFrom(x => x.Destination.SolarSystem.Id))
                .ForMember(src => src.LeadsTo, dst => dst.MapFrom(x => x.Destination.SolarSystem.Name))
                .ForMember(src => src.LeadsToSystemType, dst => dst.MapFrom(x => x.Destination.SolarSystem.SystemType.Name));

            CreateMap<SolarSystemNote, SolarSystemNoteDto>();

            CreateMap<SolarSystemTag, SolarSystemTagDto>();

            CreateMap<SolarSystemStructure, SolarSystemStructureDto>();

            CreateMap<WormholeType, WormholeTypeDto>()
                .ForMember(src => src.LeadsTo, dst => dst.MapFrom(x => x.LeadsTo.Name));

            CreateMap<Jump, JumpDto>()
                .ForMember(src => src.CharacterName, dst => dst.MapFrom(x => x.EsiCharacter.Name))
                .ForMember(src => src.Mass, dst => dst.MapFrom(x => x.Ship.Mass))
                .ForMember(src => src.ShipType, dst => dst.MapFrom(x => x.Ship.Name));
        }
    }
}
