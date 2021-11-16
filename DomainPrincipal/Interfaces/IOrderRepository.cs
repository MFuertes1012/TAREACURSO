using Domain.Entities.Productos;
using Domain.Interfaces;
using DomainPrincipal.Entities;
using DomainPrincipal.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainPrincipal.Interfaces
{
    public interface IOrderRepository : IModel<Order>
    {
        Order FindById(int orderId);
        Order[] FindByType(OrderType orderType);
        Order[] FindByStatus(OrderStatus status);
    }
}
