using EveVoid.Models.EveObjects;

namespace EveVoid.Services.EveObjects
{
    public interface IItemTypeService
    {
        ItemType GetItemTypeById(int id);
    }
}