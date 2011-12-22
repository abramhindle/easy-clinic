using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.ERP
{
    public class Inventory
    {
        public int InventoryId { set; get; }
        public Item Item { set; get; }
        public decimal Quantity { set; get; }
        public decimal NomalizeStock { set; get; }
        public decimal BuyAvg { set; get; }
        public decimal SellAvg { set; get; }
    }
}
