using EveVoid.Data;
using EveVoid.Extensions;
using EveVoid.Models.EveObjects;
using EveVoid.Models.Navigation.Masks;
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
            if (corp == null || corp.PassedMoreThan())
            {
                var esiResult = _corporationApi.GetCorporationsCorporationId(id, null, null);
                if (esiResult.AllianceId.HasValue)
                {
                    _allianceService.GetAllianceById(esiResult.AllianceId.Value);
                }
                if (corp == null)
                {
                    var newMask = new Mask();
                    _context.Masks.Add(newMask);
                    _context.SaveChanges();
                    corp = new Corporation
                    {
                        Id = id,
                        Name = esiResult.Name,
                        AllianceId = esiResult.AllianceId,
                        MaskId = newMask.Id
                    };
                    _context.Corporations.Add(corp);
                    newMask.CorporationId = id;
                    _context.SaveChanges();
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
