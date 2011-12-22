using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;

namespace Clinic.Model.ERP
{
    public class Product
    {
        public int ProductId { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Note { set; get; }
        public string BarCode { set; get; }
        public string Picture { set; get; }
        public bool IsSuppliment { set; get; }
        public bool IsPurchase { set; get; }
        public Protection Protection { set; get; }
        public string Position { set; get; }
        
        public Unit Unit { set; get; }
       

        public decimal Tax { set; get; }

        public List<Product> Dependencies { set; get; }
    }
}
