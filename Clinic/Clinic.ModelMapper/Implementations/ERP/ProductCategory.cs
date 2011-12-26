using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.ERP
{
    public class ProductCategory
    {
        public int ProductCategoryId { set; get; }
        public string Name { set; get; }
        public string Note { set; get; }
        public ProductCategory Parent { set; get; }
    }
}
