using EveVoid.Models.EveObjects;

namespace EveVoid.Services.EveObjects
{
    public interface ICorporationService
    {
        Corporation GetCorporationById(int id);
    }
}