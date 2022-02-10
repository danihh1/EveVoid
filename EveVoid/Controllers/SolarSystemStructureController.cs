using AutoMapper;
using EveVoid.Dto;
using EveVoid.Models.Navigation.MapObjects;
using EveVoid.Models.Navigation.Masks;
using EveVoid.Services.EveObjects;
using EveVoid.Services.Navigation.MapObjects;
using EveVoid.Services.Pilots;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;
using System.Linq;

namespace EveVoid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolarSystemStructureController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICharacterService _characterService;
        private readonly ISolarSystemStructureService _solarSystemStructureService;
        private readonly IItemTypeService _itemTypeService;
        private readonly IDscanService _dscanService;

        public SolarSystemStructureController(IMapper mapper,
            ICharacterService characterService,
            ISolarSystemStructureService solarSystemStructureService,
            IItemTypeService itemTypeService,
            IDscanService dscanService)
        {
            _mapper = mapper;
            _characterService = characterService;
            _solarSystemStructureService = solarSystemStructureService;
            _itemTypeService = itemTypeService;
            _dscanService = dscanService;
        }

        [HttpPost("Insert")]
        public ActionResult Insert(string mainToken, SolarSystemStructureDto dto)
        {
            var main = _characterService.GetMainCharacterByToken(mainToken);
            var maskId = main.MaskType == MaskType.Alliance && main.Pilot.Corporation.AllianceId != null ? main.Pilot.Corporation.Alliance.MaskId : main.Pilot.Corporation.MaskId;
            _itemTypeService.GetItemTypeById(dto.ItemTypeId);
            var newStructure = new SolarSystemStructure
            {
                Name = dto.Name,
                SolarSystemId = dto.SolarSystemId,
                Description = dto.Description,
                MaskId = maskId,
                ItemTypeId = dto.ItemTypeId
            };
            _solarSystemStructureService.Insert(newStructure);
            return Ok();
        }

        [HttpPut("Update")]
        public ActionResult Update(string mainToken, SolarSystemStructureDto dto)
        {
            var main = _characterService.GetMainCharacterByToken(mainToken);
            var maskId = main.MaskType == MaskType.Alliance && main.Pilot.Corporation.AllianceId != null ? main.Pilot.Corporation.Alliance.MaskId : main.Pilot.Corporation.MaskId;
            var solarSystemStructure = _solarSystemStructureService.GetById(dto.Id);
            if (solarSystemStructure == null || solarSystemStructure.MaskId != maskId)
            {
                return NotFound();
            }
            solarSystemStructure.Name = dto.Name;
            _itemTypeService.GetItemTypeById(dto.ItemTypeId);
            solarSystemStructure.ItemTypeId = dto.ItemTypeId;
            solarSystemStructure.Description = dto.Description;
            _solarSystemStructureService.Update(solarSystemStructure);
            return Ok();
        }

        [HttpDelete("")]
        public ActionResult Delete(int solarSystemStructureId)
        {
            _solarSystemStructureService.Delete(solarSystemStructureId);
            return Ok();
        }

        [HttpGet("GetById")]
        public SolarSystemStructureDto GetById(int id)
        {
            return _mapper.Map<SolarSystemStructureDto>(_solarSystemStructureService.GetById(id));
        }

        [HttpPost("InsertBulk")]
        public ActionResult InsertBulk(string mainToken, List<SolarSystemStructureDto> dtos)
        {
            var main = _characterService.GetMainCharacterByToken(mainToken);
            var maskId = main.MaskType == MaskType.Alliance && main.Pilot.Corporation.AllianceId != null ? main.Pilot.Corporation.Alliance.MaskId : main.Pilot.Corporation.MaskId;
            var addList = new List<SolarSystemStructure>();
            var shipList = new List<DscanShip>();
            foreach (var dto in dtos)
            {
                var itemType = _itemTypeService.GetItemTypeById(dto.ItemTypeId);
                if (itemType.ItemGroup.ItemCategory.Name == "Structure")
                {
                    addList.Add(new SolarSystemStructure
                    {
                        Name = dto.Name,
                        Description = dto.Description,
                        SolarSystemId = dto.SolarSystemId,
                        MaskId = maskId,
                        ItemTypeId = dto.ItemTypeId,
                    });
                }
                if (itemType.ItemGroup.ItemCategory.Name == "Ship")
                {
                    shipList.Add(new DscanShip
                    {
                        ShipName = dto.Name,
                        ShipTypeId = dto.ItemTypeId,
                    });
                }
            }
            if (shipList.Any())
            {
                var dscan = new Dscan
                {
                    DscanShips = shipList,
                    MaskId = maskId,
                    SolarSystemId = dtos.First().SolarSystemId
                };
                _dscanService.Insert(dscan);
            }
            _solarSystemStructureService.InsertBulk(addList);
            return Ok();
        }
    }
}
