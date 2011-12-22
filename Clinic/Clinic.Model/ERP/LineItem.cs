using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.ERP
{
    public class LineItem
    {
        public int LineItemId { set; get; }
        public Order OrderId { set; get; }
        public Product Product { set; get; }
        public int Quantity { set; get; }
        public decimal UnitPrice { set; get; }
        public Discount Dicount { set; get; }
        
    }
}
