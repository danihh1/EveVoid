using EveVoid.Models.EveObjects;

namespace EveVoid.Services.EveObjects
{
    public interface IAllianceService
    {
        Alliance GetAllianceById(int id);
    }
}