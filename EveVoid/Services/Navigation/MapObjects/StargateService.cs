using EveVoid.Data;
using EveVoid.Extensions;
using EveVoid.Models.Navigation.MapObjects;
using EveVoid.Models.Navigation.Matrix;
using IO.Swagger.Api;
using IO.Swagger.Model;
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

        public Stargate AddOrUpdateStargateToSystemId(int id, GetUniverseSystemsSystemIdOk system)
        {
            var gate = _context.Stargates.FirstOrDefault(x => x.Id == id);
            if (gate == null)
            {
                var esiResult = _universeApi.GetUniverseStargatesStargateId(id, null, null);
                var destoSystem = _universeApi.GetUniverseSystemsSystemId(esiResult.Destination.SystemId.Value, "en-us", null, null, "en-us");
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
                AddAdjacency(system.SystemId.Value, esiResult.Destination.SystemId.Value, -1,
                            destoSystem.SecurityStatus <= 0.45 || system.SecurityStatus <= 0.45 ? 100 : // Null/Low sec connection = 100
                            1);
                desto.DestinationId = gate.Id;
                gate.DestinationId = desto.Id;
                _context.SaveChanges();
            }
            return gate;
        }

        private void AddAdjacency(int systemId1, int systemId2, int maskId, int distance)
        {
            RemoveAdjacency(systemId1, systemId2, maskId);

            _context.AdjacencyMatrix.Add(new AdjacencyMatrix
            {
                RowNumber = systemId1,
                ColumnNumber = systemId2,
                MaskId = maskId,
                Distance = distance,
            });
            _context.AdjacencyMatrix.Add(new AdjacencyMatrix
            {
                RowNumber = systemId2,
                ColumnNumber = systemId1,
                MaskId = maskId,
                Distance = distance,
            });
            _context.SaveChanges();
        }

        public void RemoveAdjacency(int systemId1, int systemId2, int maskId)
        {
            var adjs = _context.AdjacencyMatrix.Where(a => a.MaskId == maskId && ((a.RowNumber == systemId1 && a.ColumnNumber == systemId2) || (a.ColumnNumber == systemId1 && a.RowNumber == systemId2)));
            _context.AdjacencyMatrix.RemoveRange(adjs);
            _context.SaveChanges();
        }

        public Stargate GetStargateByOriginAndDestoId(int originId, int destoId)
        {
            return _context.Stargates.FirstOrDefault(x => x.SystemId == originId && x.DestinationId != null && x.Destination.SystemId == destoId);
        }
    }
}
