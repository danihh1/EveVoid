using EveVoid.Models.Navigation.MapObjects;

namespace EveVoid.Services.Navigation.MapObjects
{
    public interface ITagService
    {
        void Delete(int tagId);
        SolarSystemTag GetById(int tagId);
        void Insert(SolarSystemTag tag);
        void Update(SolarSystemTag tag);
    }
}