using AppCore.Interfaces;
using Domain.Entities.Productos;
using DomainPrincipal.Entities;
using DomainPrincipal.Entities.Productos;
using DomainPrincipal.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCoreMain.Interfaces
{
    public interface IOrderService : IService<Order>
    {
        Order FindById(int orderId);
        Order[] FindByType(OrderType orderType);
        Order[] FindByStatus(OrderStatus status);
        void Create(Order order, OrderItem[] items);
    }
}
