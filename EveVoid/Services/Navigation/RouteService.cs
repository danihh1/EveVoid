using EveVoid.Data;
using EveVoid.Dto;
using EveVoid.Extensions;
using EveVoid.Models.Navigation.Masks;
using EveVoid.Models.Navigation.Matrix;
using EveVoid.Services.Navigation.MapObjects;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Services.Navigation
{
    public class RouteService : IRouteService
    {
        public EveVoidContext _context { get; set; }
        public ISolarSystemService _solarSystemService { get; set; }
        private readonly ILogger<RouteService> _logger;

        public RouteService(ISolarSystemService solarSystemService,
            EveVoidContext context, 
            ILogger<RouteService> logger)
        {
            _solarSystemService = solarSystemService;
            _context = context;
            _logger = logger;
        }

        public Dictionary<int, Dictionary<int, int>> GetAdjMatrix(int maskId, RouteType routeType)
        {
            var rows = _context.AdjacencyMatrix.Where(x=>x.MaskId == maskId || x.MaskId == -1).AsEnumerable()
                .GroupBy(x => x.RowNumber)
                .ToDictionary(r => r.Key, r => r.ToDictionary(c => c.ColumnNumber, c => DistanceBasedOnRouteType(c.Distance, routeType)));
            return rows;
        }

        private int DistanceBasedOnRouteType(int distance, RouteType routeType)
        {
            var res = 1;
            switch (routeType)
            {
                case RouteType.Shortest:
                    {
                        break;
                    }
                case RouteType.Hisec:
                    {
                        res = distance == 1 ? 1 : 100;
                        break;
                    }
                case RouteType.Jspace:
                    {
                        res = distance == 10 ? 1 : 100;
                        break;
                    }
                case RouteType.LowNull:
                    {
                        res = distance == 100 ? 1 : 100;
                        break;
                    }
            }
            return res;
        }

        public void AddAdjacency(int systemId1, int systemId2, int maskId, int distance)
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

        public FavoriteDistanceDto GetRoute(int maskId, int sourceId, int targetId, RouteType routeType)
        {
            var watch = new Stopwatch();
            watch.Start();
            _logger.LogInformation("Dijkstra starting");
            var matrix = GetAdjMatrix(maskId, routeType);
            var dijk = DijkstraAlgoDict(matrix, sourceId, targetId);
            _logger.LogInformation("Dijkstra Ended" + watch.Elapsed);
            watch.Stop();
            var solarSystemDict = _solarSystemService.GetAll().ToDictionary(x => x.Id, x => new { x.Name, Color = x.SystemType.Color});
            var u = targetId;
            var route = new List<int>();
            do
            {
                route.Add(u);
                u = dijk[u];
                if (u < 0)
                {
                    return new FavoriteDistanceDto
                    {
                        SystemName = solarSystemDict[targetId].Name,
                        SystemId = targetId,
                        DistanceInJumps = -1,
                        Route = new List<RouteDto>()
                    };
                }
            }
            while (dijk.ContainsKey(u) && u != sourceId);
            route.Reverse();
            var index = 0;
            var res = new FavoriteDistanceDto
            {
                SystemName = solarSystemDict[targetId].Name,
                SystemId = targetId,
                DistanceInJumps = route.Count(),
                Route = route.Select(x => new RouteDto
                {
                    SystemId = x,
                    SystemName = solarSystemDict[x].Name,
                    Order = index++,
                    Color = solarSystemDict[x].Color
                }).ToList()
            };
            return res;
            //return dijk.ContainsKey(targetId) ? dijk[targetId] : int.MaxValue;
        }

        public void RemoveAdjacency(int systemId1, int systemId2, int maskId)
        {
            var adjs = _context.AdjacencyMatrix.Where(a => a.MaskId == maskId && ((a.RowNumber == systemId1 && a.ColumnNumber == systemId2) || (a.ColumnNumber == systemId1 && a.RowNumber == systemId2)));
            _context.AdjacencyMatrix.RemoveRange(adjs);
            _context.SaveChanges();
        }

        private Dictionary<int, int> DijkstraAlgoDict(Dictionary<int, Dictionary<int, int>> graph, int source, int target)
        {
            //var verticesCount = graph.Count;
            var distance = graph.ToDictionary(x => x.Key, x => int.MaxValue);
            var shortestPathTreeSet = graph.ToDictionary(x => x.Key, x => false);
            var prev = graph.ToDictionary(x => x.Key, x => -1);

            distance[source] = 0;
            foreach (var vertex in graph)
            {
                int u = MinimumDistanceDict(distance, shortestPathTreeSet);
                if (u == target || distance[u] == int.MaxValue)
                {
                    return prev;
                }
                shortestPathTreeSet[u] = true;
                foreach (var v in graph[u].Where(x => !shortestPathTreeSet[x.Key]).Select(x => x.Key))
                {
                    var alt = distance[u] + graph[u][v];
                    //if (!shortestPathTreeSet[v] && 
                    //    distance[u] != int.MaxValue && 
                    //    distance[u] + (useDistance ? graph[u][v] : 1) < distance[v])
                    if (alt < distance[v])
                    {
                        distance[v] = alt;
                        prev[v] = u;
                    }
                }
            }
            //var solarSystemNames = _solarSystemService.GetAll().ToDictionary(x => x.Id, x => x.Name);
            //_logger.LogInformation(String.Join(",",distance.Where(x=> x.Value < 1000).OrderBy(x => x.Value).Select(x => solarSystemNames[x.Key] + "(" + x.Value + ")").ToArray()));
            return prev;
            // Print(distance, verticesCount);
        }

        private int MinimumDistanceDict(Dictionary<int, int> distance, Dictionary<int, bool> shortestPathTreeSet)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            foreach (var v in shortestPathTreeSet.Where(x => !x.Value).Select(x => x.Key))
            {
                if (distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }
    }
}
