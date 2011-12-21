using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.Infrastructure
{
    public class Province
    {
        public int ProvinceId { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public Country Country { set; get; }
    }
}
