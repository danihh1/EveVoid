using EveVoid.Models.Navigation.MapObjects;

namespace EveVoid.Services.Navigation.MapObjects
{
    public interface ISolarSystemNoteService
    {
        void Delete(int noteId);
        SolarSystemNote GetById(int noteId);
        void Insert(SolarSystemNote note);
        void Update(SolarSystemNote note);
    }
}