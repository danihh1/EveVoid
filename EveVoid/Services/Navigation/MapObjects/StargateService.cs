using EveVoid.Data;
using EveVoid.Extensions;
using EveVoid.Models.Navigation.MapObjects;
using IO.Swagger.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

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
            if (gate == null)
            {
                var esiResult = _universeApi.GetUniverseStargatesStargateId(id, null, null);
                var desto = new Stargate
                {
                    Id = esiResult.Destination.StargateId.Value,
                    SystemId = esiResult.Destination.SystemId.Value,
                    
                };
                _context.Stargates.Add(desto);
                gate = new Stargate
                {
                    Id = id,
                    SystemId = esiResult.SystemId.Value,
                };
                _context.Stargates.Add(gate);
                _context.SaveChanges();
                desto.DestinationId = gate.Id;
                gate.DestinationId = desto.Id;
                _context.SaveChanges();
            }
            return gate;
        }

        public Stargate GetStargateByOriginAndDestoId(int originId, int destoId)
        {
            return _context.Stargates.FirstOrDefault(x => x.SystemId == originId && x.DestinationId != null && x.Destination.SystemId == destoId);
        }
    }
}
