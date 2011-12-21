using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.ERP
{
    /// <summary>
    /// Nhom hang
    /// </summary>
    public class ProductGroup
    {
        public int ProductGroupId { set; get; }
        public ProductIndustry ProductIndustry { set; get; }
        public string Name { set; get; }
        public string Note { set; get; }       
        public Discount Discount { set; get; }
        public decimal Tax { set; get; }

    }
}
