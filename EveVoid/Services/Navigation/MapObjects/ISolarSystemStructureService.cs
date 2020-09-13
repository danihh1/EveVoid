using EveVoid.Models.Navigation.MapObjects;
using System.Collections.Generic;

namespace EveVoid.Services.Navigation.MapObjects
{
    public interface ISolarSystemStructureService
    {
        void Delete(int structureId);
        SolarSystemStructure GetById(int structureId);
        void Insert(SolarSystemStructure structure, bool commit = true);
        void Update(SolarSystemStructure structure);
        void InsertBulk(List<SolarSystemStructure> structures);
    }
}