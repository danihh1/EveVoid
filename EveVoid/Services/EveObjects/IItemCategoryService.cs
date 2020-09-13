using EveVoid.Models.EveObjects;

namespace EveVoid.Services.EveObjects
{
    public interface IItemCategoryService
    {
        ItemCategory GetItemCategoryById(int id);
    }
}