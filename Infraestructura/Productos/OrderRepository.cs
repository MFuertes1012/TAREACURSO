using Domain.Entities.Productos;
using DomainPrincipal.Entities;
using DomainPrincipal.Enums;
using DomainPrincipal.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Productos
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public Order FindById(int orderId)
        {
            throw new NotImplementedException();
        }
        public Order[] FindByStatus(OrderStatus status)
        {
            throw new NotImplementedException();
        }
        public Order[] FindByType(OrderType orderType)
        {
            throw new NotImplementedException();
        }
    }
}
