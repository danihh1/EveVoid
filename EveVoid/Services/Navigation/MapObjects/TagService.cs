using EveVoid.Data;
using EveVoid.Models.Navigation.MapObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Services.Navigation.MapObjects
{
    public class TagService : ITagService
    {
        public EveVoidContext _context { get; set; }
        public ISolarSystemService _solarSystemService { get; set; }

        public TagService(EveVoidContext context, ISolarSystemService solarSystemService)
        {
            _context = context;
            _solarSystemService = solarSystemService;
        }

        public void Insert(SolarSystemTag tag)
        {
            var duplicates = _context.SolarSystemTags.Where(x => x.Icon == tag.Icon && x.Name == tag.Name && x.Color == tag.Color && x.SolarSystemId == tag.SolarSystemId);
            _context.RemoveRange(duplicates);
            _context.SolarSystemTags.Add(tag);
            _context.SaveChanges();
        }

        public void Update(SolarSystemTag tag)
        {
            _context.Update(tag);
            _context.SaveChanges();
        }

        public void Delete(int tagId)
        {
            var tag = GetById(tagId);
            _context.Remove(tag);
            _context.SaveChanges();
        }

        public SolarSystemTag GetById(int tagId)
        {
            var tag = _context.SolarSystemTags.FirstOrDefault(x => x.Id == tagId);
            return tag;
        }
    }
}
