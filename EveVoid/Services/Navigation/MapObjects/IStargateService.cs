using EveVoid.Models.Navigation.MapObjects;

namespace EveVoid.Services.Navigation.MapObjects
{
    public interface IStargateService
    {
        Stargate AddOrUpdateStargateToSystemId(int id, int systemId);
    }
}