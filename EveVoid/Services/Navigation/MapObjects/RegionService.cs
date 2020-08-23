using EveVoid.Data;
using EveVoid.Extensions;
using EveVoid.Models.Navigation.MapObjects;
using IO.Swagger.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Services.Navigation.MapObjects
{
    public class RegionService : IRegionService
    {
        public EveVoidContext _context { get; set; }
        public IUniverseApi _universeApi { get; set; }

        public RegionService(EveVoidContext context,
            IUniverseApi universeApi)
        {
            _context = context;
            _universeApi = universeApi;
        }

        public Region GetRegionById(int id)
        {
            var region = _context.Regions.FirstOrDefault(x => x.Id == id);
            if (region == null || region.PassedMoreThan(days: 7))
            {
                var esiResult = _universeApi.GetUniverseRegionsRegionId(id, "en-us", null, null, "en-us");
                if (region == null)
                {
                    region = new Region
                    {
                        Id = id,
                        Name = esiResult.Name
                    };
                    _context.Regions.Add(region);
                }
                else
                {
                    region.Name = esiResult.Name;
                }
                _context.SaveChanges();
            }
            return region;
        }
    }
}
