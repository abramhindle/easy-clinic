using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.Infrastructure
{
    public class Country
    {
        public string CouCode { set; get; }
        public string Name { set; get; }
        public string Iso3 { set; get; }
        public int NumCode { set; get; }
    }
}
