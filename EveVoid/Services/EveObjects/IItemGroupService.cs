using EveVoid.Models.EveObjects;

namespace EveVoid.Services.EveObjects
{
    public interface IItemGroupService
    {
        ItemGroup GetItemGroupById(int id);
    }
}