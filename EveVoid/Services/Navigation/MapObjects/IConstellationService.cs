using EveVoid.Models.Navigation.MapObjects;

namespace EveVoid.Services.Navigation.MapObjects
{
    public interface IConstellationService
    {
        Constellation GetConstellationById(int id);
    }
}