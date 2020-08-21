using EveVoid.Services.Navigation.MapObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Services.Navigation
{
    public class RouteService
    {
        public ISolarSystemService _solarSystemService { get; set; }

        public RouteService(ISolarSystemService solarSystemService)
        {
            _solarSystemService = solarSystemService;
        }
    }
}
