using DomainPrincipal.Entities.Productos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCoreMain.Interfaces
{
    public interface IInventoryCalculator
    {
        decimal CalculateSalesCost(OrderItem[] saleOrderItems);
        decimal CalculateFinalInventory(Item[] items);
    }
}
