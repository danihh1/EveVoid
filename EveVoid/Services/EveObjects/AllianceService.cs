using EveVoid.Data;
using EveVoid.Models.EveObjects;
using EveVoid.Models.Navigation.Masks;
using IO.Swagger.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Services.EveObjects
{
    public class AllianceService : IAllianceService
    {
        public EveVoidContext _context { get; set; }
        public IAllianceApi _allianceApi { get; set; }
        public AllianceService(EveVoidContext context,
            IAllianceApi allianceApi)
        {
            _context = context;
            _allianceApi = allianceApi;
        }

        public Alliance GetAllianceById(int id)
        {
            var alliance = _context.Alliances.FirstOrDefault(x => x.Id == id);
            if (alliance == null)
            {
                var esiResult = _allianceApi.GetAlliancesAllianceId(id, null, null);
                var newMask = new Mask();
                _context.Masks.Add(newMask);
                _context.SaveChanges();
                alliance = new Alliance
                {
                    Id = id,
                    Name = esiResult.Name,
                    MaskId = newMask.Id
                };
                _context.Alliances.Add(alliance);
                _context.SaveChanges();
                newMask.AllianceId = id;
                _context.SaveChanges();
            }
            return alliance;
        }
    }
}
