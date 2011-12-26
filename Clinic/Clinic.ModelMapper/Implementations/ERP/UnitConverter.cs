using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.ERP
{
    public class UnitConverter
    {
        public int UnitConverterId { set; get; }
        public UnitOfMeansure Source { set; get; }
        public UnitOfMeansure Target { set; get; }
        public decimal Value { set; get; }
    }
}
