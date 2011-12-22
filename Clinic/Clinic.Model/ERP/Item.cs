using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;

namespace Clinic.Model.ERP
{
    public class Item
    {
        public int ItemId { set; get; }
        public Product Product { set; get; }
        public Customer Supplier { set; get; }
        public string Name { set; get; }
        public string Status { set; get; }
        public string Image { set; get; }
        public decimal UnitCost { set; get; }
        public decimal ListedPrice { set; get; }
        public decimal RetailPrice { set; get; }
        public Discount Discount { set; get; }
        public DateTime ManufactureDate { set; get; }
        public DateTime ExpirationDate { set; get; }

    }
}
