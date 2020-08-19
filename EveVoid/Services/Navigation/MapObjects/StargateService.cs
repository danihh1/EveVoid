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
    public class StargateService : IStargateService
    {
        public EveVoidContext _context { get; set; }
        public IUniverseApi _universeApi { get; set; }

        public StargateService(EveVoidContext context, IUniverseApi universeApi)
        {
            _context = context;
            _universeApi = universeApi;
        }

        public Stargate AddOrUpdateStargateToSystemId(int id, int systemId)
        {
            var gate = _context.Stargates.FirstOrDefault(x => x.Id == id);
            if (gate == null || gate.DestinationId == null || gate.ShouldUpdate())
            {
                var esiResult = _universeApi.GetUniverseStargatesStargateId(id, null, null);
                var desto = _context.Stargates.FirstOrDefault(x => x.Id == esiResult.Destination.StargateId);
                if (gate == null)
                {
                    gate = new Stargate
                    {
                        Id = id,
                        SystemId = esiResult.SystemId.Value,
                        DestinationId = desto == null ? (int?)null : desto.Id,
                    };
                    _context.Stargates.Add(gate);
                }
                else
                {
                    gate.DestinationId = desto == null ? default : desto.Id;
                }
            }
            _context.SaveChanges();
            return gate;
        }
    }
}
