using EveVoid.Data;
using EveVoid.Models.EveObjects;
using IO.Swagger.Api;

namespace EveVoid.Services.EveObjects
{
    public interface IShipService
    {
        Ship GetShipById(int id);
    }
}