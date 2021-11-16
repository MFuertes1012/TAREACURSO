using AppCore.Services;
using AppCoreMain.Interfaces;
using DomainPrincipal.Entities.Productos;
using DomainPrincipal.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCoreMain.Services
{
    public class ItemService : BaseService<Item>, IItemService
    {
        private IItemRepository itemRepository;

        public ItemService(IItemRepository itemRepository) : base(itemRepository)
        {
            this.itemRepository = itemRepository;
        }

   
        public Item[] FindByProductId(int productId)
        {
            return itemRepository.FindByProductId(productId);
        }

       
    }
}