using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.ERP
{
    public class Product
    {
        public int ProductId { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Note { set; get; }
        public string Picture { set; get; }
        public bool IsSuppliment { set; get; }
        
        public Unit Unit { set; get; }
        public decimal InPrice { set; get; }
        public decimal OutPrice { set; get; }
        public decimal RetailPrice { set; get; }
        public decimal NomalizeStock { set; get; }
        public Discount Discount { set; get; }
        public decimal Bonus { set; get; }
        public decimal Tax { set; get; }
    }
}
