using EveVoid.Data;
using EveVoid.Extensions;
using EveVoid.Models.EveObjects;
using IO.Swagger.Api;
using System.Linq;

namespace EveVoid.Services.EveObjects
{
    public class ItemGroupService : IItemGroupService
    {
        public EveVoidContext _context { get; set; }
        public IUniverseApi _universeApi { get; set; }
        public IItemCategoryService _ItemCategoryService { get; set; }
        public ItemGroupService(EveVoidContext context,
            IUniverseApi universeApi, 
            IItemCategoryService itemCategoryService)
        {
            _context = context;
            _universeApi = universeApi;
            _ItemCategoryService = itemCategoryService;
        }

        public ItemGroup GetItemGroupById(int id)
        {
            var itemGroup = _context.ItemGroups.FirstOrDefault(x => x.Id == id);
            if (itemGroup == null || itemGroup.PassedMoreThan(days: 30))
            {
                var esiResult = _universeApi.GetUniverseGroupsGroupId(id, "en-us", null, null, "en-us");
                _ItemCategoryService.GetItemCategoryById(esiResult.CategoryId.Value);
                if (itemGroup == null)
                {
                    itemGroup = new ItemGroup
                    {
                        Id = id,
                        Name = esiResult.Name,
                        ItemCategoryId = esiResult.CategoryId.Value
                    };
                    _context.ItemGroups.Add(itemGroup);
                }
                else
                {
                    itemGroup.Name = esiResult.Name;
                    itemGroup.ItemCategoryId = esiResult.CategoryId.Value;
                }
            }
            _context.SaveChanges();
            return itemGroup;
        }
    }
}
