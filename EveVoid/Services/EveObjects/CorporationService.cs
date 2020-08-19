using EveVoid.Data;
using EveVoid.Extensions;
using EveVoid.Models.EveObjects;
using IO.Swagger.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Services.EveObjects
{
    public class CorporationService : ICorporationService
    {
        public EveVoidContext _context { get; set; }
        public ICorporationApi _corporationApi { get; set; }
        public IAllianceService _allianceService { get; set; }

        public CorporationService(EveVoidContext context,
            ICorporationApi corporationApi,
            IAllianceService allianceService)
        {
            _context = context;
            _corporationApi = corporationApi;
            _allianceService = allianceService;
        }

        public Corporation GetCorporationById(int id)
        {
            var corp = _context.Corporations.FirstOrDefault(x => x.Id == id);
            if (corp == null || corp.ShouldUpdate())
            {
                var esiResult = _corporationApi.GetCorporationsCorporationId(id, null, null);
                if (esiResult.AllianceId.HasValue)
                {
                    _allianceService.GetAllianceById(esiResult.AllianceId.Value);
                }
                if (corp == null)
                {
                    corp = new Corporation
                    {
                        Id = id,
                        Name = esiResult.Name,
                        AllianceId = esiResult.AllianceId
                    };
                    _context.Corporations.Add(corp);
                }
                else
                {
                    corp.AllianceId = esiResult.AllianceId;
                }
            }
            _context.SaveChanges();
            return corp;
        }
    }
}
