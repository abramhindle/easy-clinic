using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.ERP
{
    public class Discount
    {
        public int DiscountId { set; get; }
        public string Name { set; get; }
        public decimal Value { set; get; }
    }
}
