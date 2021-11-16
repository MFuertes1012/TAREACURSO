using Domain.Interfaces;
using DomainPrincipal.Entities.Productos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainPrincipal.Interfaces
{
    public interface IItemRepository : IModel<Item>
    {
        Item FindById(int id);
        Item[] FindByProductId(int productId);
    }
}
