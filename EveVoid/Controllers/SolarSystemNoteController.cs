using AutoMapper;
using EveVoid.Dto;
using EveVoid.Models.Navigation.MapObjects;
using EveVoid.Models.Navigation.Masks;
using EveVoid.Services.EveObjects;
using EveVoid.Services.Navigation.MapObjects;
using EveVoid.Services.Pilots;
using Microsoft.AspNetCore.Mvc;

namespace EveVoid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolarSystemNoteController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICharacterService _characterService;
        private readonly ISolarSystemNoteService _solarSystemNoteService;

        public SolarSystemNoteController(IMapper mapper,
            ICharacterService characterService,
            ISolarSystemNoteService solarSystemNoteService)
        {
            _mapper = mapper;
            _characterService = characterService;
            _solarSystemNoteService = solarSystemNoteService;
        }

        [HttpPost("Insert")]
        public ActionResult Insert(string mainToken, SolarSystemNoteDto dto)
        {
            var main = _characterService.GetMainCharacterByToken(mainToken);
            var maskId = main.MaskType == MaskType.Alliance && main.Pilot.Corporation.AllianceId != null ? main.Pilot.Corporation.Alliance.MaskId : main.Pilot.Corporation.MaskId;

            var newNote = new SolarSystemNote
            {
                MainCharacterId = main.Id,
                SolarSystemId = dto.SolarSystemId,
                MaskId = maskId,
                Content = dto.Content
            };
            _solarSystemNoteService.Insert(newNote);
            return Ok();
        }

        [HttpPut("Update")]
        public ActionResult Update(string mainToken, SolarSystemNoteDto dto)
        {
            var main = _characterService.GetMainCharacterByToken(mainToken);
            var maskId = main.MaskType == MaskType.Alliance && main.Pilot.Corporation.AllianceId != null ? main.Pilot.Corporation.Alliance.MaskId : main.Pilot.Corporation.MaskId;
            var solarSystemNote = _solarSystemNoteService.GetById(dto.Id);
            if (solarSystemNote == null || solarSystemNote.MaskId != maskId)
            {
                return NotFound();
            }
            solarSystemNote.Content = dto.Content;
            _solarSystemNoteService.Update(solarSystemNote);
            return Ok();
        }

        [HttpDelete("")]
        public ActionResult Delete(int solarSystemNoteId)
        {
            _solarSystemNoteService.Delete(solarSystemNoteId);
            return Ok();
        }

        [HttpGet("GetById")]
        public SolarSystemNoteDto GetById(int id)
        {
            return _mapper.Map<SolarSystemNoteDto>(_solarSystemNoteService.GetById(id));
        }
    }
}
