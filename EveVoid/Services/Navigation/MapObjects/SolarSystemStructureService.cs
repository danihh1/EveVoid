using EveVoid.Data;
using EveVoid.Models.Navigation.MapObjects;
using System.Collections.Generic;
using System.Linq;

namespace EveVoid.Services.Navigation.MapObjects
{
    public class SolarSystemStructureService : ISolarSystemStructureService
    {
        public EveVoidContext _context { get; set; }
        public ISolarSystemService _solarSystemService { get; set; }

        public SolarSystemStructureService(EveVoidContext context, ISolarSystemService solarSystemService)
        {
            _context = context;
            _solarSystemService = solarSystemService;
        }

        public void Insert(SolarSystemStructure structure, bool commit = true)
        {
            var duplicates = _context.SolarSystemStructures.Where(x => x.Name == structure.Name && x.ItemTypeId == structure.ItemTypeId && x.SolarSystemId == structure.SolarSystemId).ToList();
            if (duplicates.Count() == 0)
            {
                _context.SolarSystemStructures.Add(structure);
            }
            else
            {
                foreach (var dup in duplicates)
                {
                    _context.Update(dup);
                }
            }
            if (commit)
            {
                _context.SaveChanges();
            }
        }

        public void Update(SolarSystemStructure structure)
        {
            _context.Update(structure);
            _context.SaveChanges();
        }

        public void Delete(int structureId)
        {
            var structure = GetById(structureId);
            _context.Remove(structure);
            _context.SaveChanges();
        }

        public SolarSystemStructure GetById(int structureId)
        {
            var structure = _context.SolarSystemStructures.FirstOrDefault(x => x.Id == structureId);
            return structure;
        }

        public void InsertBulk(List<SolarSystemStructure> structures)
        {
            foreach(var structure in structures)
            {
                Insert(structure, commit:false);
            }
            _context.SaveChanges();
        }
    }
}
