using Domain.Interfaces;
using DomainPrincipal.Entities.Productos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainPrincipal.Interfaces
{
    public interface IOrderItemRepository : IModel<OrderItem>
    {
        OrderItem[] FindByProductId(int productId);
        OrderItem[] FindByOrderId(int OrderId);
        OrderItem[] FindByItemId(int itemId);
    }
}
