using EveVoid.Data;
using EveVoid.Models.Navigation.MapObjects;
using System.Collections.Generic;
using System.Linq;

namespace EveVoid.Services.Navigation.MapObjects
{
    public class SolarSystemNoteService : ISolarSystemNoteService
    {
        public EveVoidContext _context { get; set; }
        public ISolarSystemService _solarSystemService { get; set; }

        public SolarSystemNoteService(EveVoidContext context, ISolarSystemService solarSystemService)
        {
            _context = context;
            _solarSystemService = solarSystemService;
        }

        public void Insert(SolarSystemNote note)
        {
            _context.SolarSystemNotes.Add(note);
            _context.SaveChanges();
        }

        public void Update(SolarSystemNote note)
        {
            _context.Update(note);
            _context.SaveChanges();
        }

        public void Delete(int noteId)
        {
            var note = GetById(noteId);
            _context.Remove(note);
            _context.SaveChanges();
        }

        public SolarSystemNote GetById(int noteId)
        {
            var note = _context.SolarSystemNotes.FirstOrDefault(x => x.Id == noteId);
            return note;
        }
    }
}
