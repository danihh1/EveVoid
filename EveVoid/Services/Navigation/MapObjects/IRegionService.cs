using EveVoid.Models.Navigation.MapObjects;

namespace EveVoid.Services.Navigation.MapObjects
{
    public interface IRegionService
    {
        Region GetRegionById(int id);
    }
}