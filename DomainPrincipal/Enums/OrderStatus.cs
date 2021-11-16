using System;
using System.Collections.Generic;
using System.Text;

namespace DomainPrincipal.Entities
{
    public enum OrderStatus
    {
        New,
        Checkout,
        Paid,
        Failed,
        Shipped,
        Delivered,
        Returned,
        Complete
    }
}
