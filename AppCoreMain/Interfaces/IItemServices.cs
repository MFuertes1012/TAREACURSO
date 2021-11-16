using AppCore.Interfaces;
using DomainPrincipal.Entities.Productos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCoreMain.Interfaces
{
    public interface IItemService : IService<Item>
    {
        Item FindById(int id);
        Item[] FindByProductId(int productId);
    }
}
