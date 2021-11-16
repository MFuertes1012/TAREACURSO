using DomainPrincipal.Entities.Productos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCoreMain.Filtro
{
    public class OrderItemSortByOrderDate : IComparer<OrderItem>
    {
        public int Compare(OrderItem x, OrderItem y)
        {
            return x.Order.Date.CompareTo(y.Order.Date);
        }
    }
}
