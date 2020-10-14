using EveVoid.Models.Navigation.MapObjects;
using IO.Swagger.Model;

namespace EveVoid.Services.Navigation.MapObjects
{
    public interface IStargateService
    {
        Stargate AddOrUpdateStargateToSystemId(int id, GetUniverseSystemsSystemIdOk system);
        Stargate GetStargateByOriginAndDestoId(int originId, int destoId);
    }
}