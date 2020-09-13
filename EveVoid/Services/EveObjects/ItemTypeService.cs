using EveVoid.Data;
using EveVoid.Extensions;
using EveVoid.Models.EveObjects;
using IO.Swagger.Api;
using System.Collections.Generic;
using System.Linq;

namespace EveVoid.Services.EveObjects
{
    public class ItemTypeService : IItemTypeService
    {
        public EveVoidContext _context { get; set; }
        public IUniverseApi _universeApi { get; set; }
        public IItemGroupService _itemGroupService { get; set; }
        public ItemTypeService(EveVoidContext context,
            IUniverseApi universeApi, 
            IItemGroupService itemGroupService)
        {
            _context = context;
            _universeApi = universeApi;
            _itemGroupService = itemGroupService;
        }

        public ItemType GetItemTypeById(int id)
        {
            var itemType = _context.ItemTypes.FirstOrDefault(x => x.Id == id);
            if (itemType == null || itemType.PassedMoreThan(days: 30))
            {
                var esiResult = _universeApi.GetUniverseTypesTypeId(id, "en-us", null, null, "en-us");
                _itemGroupService.GetItemGroupById(esiResult.GroupId.Value);
                if (itemType == null)
                {
                    itemType = new ItemType
                    {
                        Id = id,
                        Name = esiResult.Name,
                        Description = esiResult.Description,
                        Mass = esiResult.Mass.GetValueOrDefault(),
                        ItemGroupId = esiResult.GroupId.Value
                    };
                    _context.ItemTypes.Add(itemType);
                }
                else
                {
                    itemType.Name = esiResult.Name;
                    itemType.Description = esiResult.Description;
                }
            }
            _context.SaveChanges();
            return itemType;
        }
    }
}
