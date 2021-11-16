using AppCore.Interfaces;
using DomainPrincipal.Entities.Productos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCoreMain.Interfaces
{
    public interface IOrderItemService : IService<OrderItem>
    {
        OrderItem[] FindByProductId(int productId);
        OrderItem[] FindByOrderId(int OrderId);
        OrderItem[] FindByItemId(int itemId);
    }
}
