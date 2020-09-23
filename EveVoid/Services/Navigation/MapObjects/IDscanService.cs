using EveVoid.Models.Navigation.MapObjects;

namespace EveVoid.Services.Navigation.MapObjects
{
    public interface IDscanService
    {
        void Delete(int dscanId);
        Dscan GetById(int dscanId);
        void Insert(Dscan dscan);
        void Update(Dscan dscan);
    }
}