using AutoMapper;
using EveVoid.Dto;
using EveVoid.Models.Pilots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.AutoMapper
{
    public class CharacterProfile:Profile
    {
        public CharacterProfile()
        {
            CreateMap<MainCharacter, MainCharacterDto>()
                .ForMember(src => src.AllianceId, dst => dst.MapFrom(x => x.Corporation.AllianceId))
                .ForMember(src => src.AllianceName, dst => dst.MapFrom(x => x.Corporation.Alliance.Name))
                .AfterMap((entity,dto,ctx) =>
                {
                    dto.MapLayouts = dto.MapLayouts.OrderBy(x => x.Order).ToList();
                });

            CreateMap<EsiCharacter, EsiCharacterDto>()
                .ForMember(src => src.AllianceId, dst => dst.MapFrom(x => x.Corporation.AllianceId))
                .ForMember(src => src.AllianceName, dst => dst.MapFrom(x => x.Corporation.Alliance.Name))
                .ForMember(src => src.CurrentShipTypeName, dst => dst.MapFrom(x => x.CurrentShip.Name))
                .ForMember(src => src.EsiToken, dst => dst.MapFrom(x => x.AccessToken));

            CreateMap<MapLayout, MapLayoutDto>();
        }
    }
}
