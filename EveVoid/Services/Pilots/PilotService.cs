using EveVoid.Data;
using EveVoid.Extensions;
using EveVoid.Models.Pilots;
using EveVoid.Services.EveObjects;
using IO.Swagger.Api;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;

namespace EveVoid.Services.Pilots
{
    public class PilotService : IPilotService
    {
        public EveVoidContext _context { get; set; }
        public ICharacterApi _characterApi { get; set; }
        public ICorporationService _corporationService { get; set; }

        public PilotService(EveVoidContext context,
            ICharacterApi characterApi,
            ICorporationService corporationService)
        {
            _context = context;
            _characterApi = characterApi;
            _corporationService = corporationService;
        }

        public Pilot GetPilotById(int id)
        {
            var pilot = _context.Pilots.FirstOrDefault(p => p.Id == id);
            if (pilot == null || pilot.PassedMoreThan())
            {
                var esiResult = _characterApi.GetCharactersCharacterId(id, null, null);
                if (esiResult.CorporationId.HasValue)
                {
                    _corporationService.GetCorporationById(esiResult.CorporationId.Value);
                }
                if (pilot == null)
                {
                    pilot = new Pilot
                    {
                        Id = id,
                        CorporationId = esiResult.CorporationId.Value,
                        Name = esiResult.Name,
                    };
                    _context.Pilots.Add(pilot);
                }
                else
                {
                    pilot.CorporationId = esiResult.CorporationId.Value;
                    pilot.Name = esiResult.Name;
                }
                _context.SaveChanges();
            }
            return pilot;
        }
    }
}
