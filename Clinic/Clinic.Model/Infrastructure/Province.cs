using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.Infrastructure
{
    public class Province
    {
        public int Id { set; get; }
        public string ProvinceCode { set; get; }
        public string Name { set; get; }
        public string CountryCode { set; get; }
    }
}
