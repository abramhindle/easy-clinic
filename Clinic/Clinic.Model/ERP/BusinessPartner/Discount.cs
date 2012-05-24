using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;
using Clinic.Model.Inventories;

namespace Clinic.Model.ERP
{
    public class Discount
    {
        public int DiscountId { set; get; }
        public string Name { set; get; }
        public decimal Value { set; get; }
        public bool IsActive { set; get; }
        public List<Product> Products { set; get; }
        public List<Partner> Partners { set; get; }
        public List<ProductCategory> Categories { set; get; }
    }
}
