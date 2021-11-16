using DomainPrincipal.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainPrincipal.Entities.Productos
{
    public class InventorySummary
    {
        public DateTime Date { get; set; }
        public OrderType Type { get; set; }
        public int Unit { get; set; }
        public decimal UnitCost { get; set; }
        public decimal FinalInventory { get; set; }
        public decimal SalesCost { get; set; }
    }
}
