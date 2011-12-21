using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.Infrastructure
{
    public class District
    {
        public string DistrictId { set; get; }
        public string Name { set; get; }
        public Province Province { set; get; }
    }
}
