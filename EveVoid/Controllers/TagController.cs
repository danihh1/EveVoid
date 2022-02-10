using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EveVoid.Dto;
using EveVoid.Models.Navigation.MapObjects;
using EveVoid.Models.Navigation.Masks;
using EveVoid.Services.Navigation.MapObjects;
using EveVoid.Services.Pilots;
using IO.Swagger.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EveVoid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITagService _tagService;
        private readonly ICharacterService _characterService;

        public TagController(IMapper mapper, 
            ITagService tagService, 
            ICharacterService characterService)
        {
            _mapper = mapper;
            _tagService = tagService;
            _characterService = characterService;
        }

        [HttpPost("Insert")]
        public ActionResult InsertTag(string mainToken, SolarSystemTagDto dto)
        {
            var main = _characterService.GetMainCharacterByToken(mainToken);
            var maskId = main.MaskType == MaskType.Alliance && main.Pilot.Corporation.AllianceId != null ? main.Pilot.Corporation.Alliance.MaskId : main.Pilot.Corporation.MaskId;
            var newTag = new SolarSystemTag
            {
                Color = dto.Color,
                Name = dto.Name,
                SolarSystemId = dto.SolarSystemId,
                MaskId = maskId,
                ExpiryDate = dto.ExpiryDate,
                Icon = dto.Icon
            };
            _tagService.Insert(newTag);
            return Ok();
        }

        [HttpPut("Update")]
        public ActionResult UpdateTag(string mainToken, SolarSystemTagDto dto)
        {
            var main = _characterService.GetMainCharacterByToken(mainToken);
            var maskId = main.MaskType == MaskType.Alliance && main.Pilot.Corporation.AllianceId != null ? main.Pilot.Corporation.Alliance.MaskId : main.Pilot.Corporation.MaskId;
            var tag = _tagService.GetById(dto.Id);
            if (tag == null || tag.MaskId != maskId)
            {
                return NotFound();
            }
            tag.Name = dto.Name;
            tag.Color = dto.Color;
            tag.ExpiryDate = dto.ExpiryDate;
            tag.Icon = dto.Icon;
            _tagService.Update(tag);
            return Ok();
        }

        [HttpDelete("")]
        public ActionResult DeleteTag(int tagId)
        {
            _tagService.Delete(tagId);
            return Ok();
        }

        [HttpGet("GetById")]
        public SolarSystemTagDto GetTagById(int id)
        {
            return _mapper.Map<SolarSystemTagDto>(_tagService.GetById(id));
        }
    }
}
