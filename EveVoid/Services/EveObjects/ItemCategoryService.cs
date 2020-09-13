using EveVoid.Data;
using EveVoid.Extensions;
using EveVoid.Models.EveObjects;
using IO.Swagger.Api;
using System.Linq;

namespace EveVoid.Services.EveObjects
{
    public class ItemCategoryService : IItemCategoryService
    {
        public EveVoidContext _context { get; set; }
        public IUniverseApi _universeApi { get; set; }
        public ItemCategoryService(EveVoidContext context,
            IUniverseApi universeApi)
        {
            _context = context;
            _universeApi = universeApi;
        }

        public ItemCategory GetItemCategoryById(int id)
        {
            var itemCategory = _context.ItemCategories.FirstOrDefault(x => x.Id == id);
            if (itemCategory == null || itemCategory.PassedMoreThan(days: 30))
            {
                var esiResult = _universeApi.GetUniverseCategoriesCategoryId(id, "en-us", null, null, "en-us");
                if (itemCategory == null)
                {
                    itemCategory = new ItemCategory
                    {
                        Id = id,
                        Name = esiResult.Name,
                    };
                    _context.ItemCategories.Add(itemCategory);
                }
                else
                {
                    itemCategory.Name = esiResult.Name;
                }
            }
            _context.SaveChanges();
            return itemCategory;
        }
    }
}
