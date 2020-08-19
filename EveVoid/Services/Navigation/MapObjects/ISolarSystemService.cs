using EveVoid.Models.Navigation.MapObjects;

namespace EveVoid.Services.Navigation.MapObjects
{
    public interface ISolarSystemService
    {
        SolarSystem GetSystemById(int id);
        int GetSystemTypeIdBySecStatusAndName(double secStatus, string name);
    }
}