using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.Infrastructure
{
    public class City
    {
        public int CityId { set; get; }
        public string Name { set; get; }
        public Province Province { set; get; }
    }
}
