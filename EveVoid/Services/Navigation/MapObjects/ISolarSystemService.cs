using EveVoid.Models.Navigation.MapObjects;
using System.Collections.Generic;

namespace EveVoid.Services.Navigation.MapObjects
{
    public interface ISolarSystemService
    {
        SolarSystem GetSystemById(int id);
        void UpdateSystem(SolarSystem solarSystem);
        List<SolarSystem> Find(string name, int pageSize);
        List<SolarSystem> GetAll();
    }
}