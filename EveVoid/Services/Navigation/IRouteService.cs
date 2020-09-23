using EveVoid.Dto;
using EveVoid.Models.Navigation.Masks;
using EveVoid.Models.Navigation.Matrix;
using System.Collections.Generic;

namespace EveVoid.Services.Navigation
{
    public interface IRouteService
    {
        Dictionary<int, Dictionary<int, int>> GetAdjMatrix(int maskId, RouteType routeType);
        void AddAdjacency(int systemId1, int systemId2, int maskId, int distance);
        void RemoveAdjacency(int systemId1, int systemId2, int maskId);
        FavoriteDistanceDto GetRoute(int maskId, int sourceId, int targetId, RouteType routeType);
    }
}