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
    public class ShipService : IShipService
    {
        public EveVoidContext _context { get; set; }
        public IUniverseApi _universeApi { get; set; }
        public ShipService(EveVoidContext context,
            IUniverseApi universeApi)
        {
            _context = context;
            _universeApi = universeApi;
        }

        public Ship GetShipById(int id)
        {
            var ship = _context.Ships.FirstOrDefault(x => x.Id == id);
            if (ship == null || ship.PassedMoreThan(days: 7))
            {
                var esiResult = _universeApi.GetUniverseTypesTypeId(id, "en-us", null, null, "en-us");
                if (ship == null)
                {
                    ship = new Ship
                    {
                        Id = id,
                        Name = esiResult.Name,
                        Mass = esiResult.Mass.GetValueOrDefault()
                    };
                    _context.Ships.Add(ship);
                }
                else
                {
                    ship.Name = esiResult.Name;
                    ship.Mass = esiResult.Mass.GetValueOrDefault();
                }
            }
            _context.SaveChanges();
            return ship;
        }
    }
}
