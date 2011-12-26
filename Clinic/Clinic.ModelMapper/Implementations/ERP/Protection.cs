using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.ERP
{
    public class Protection
    {
        public int ProtectionId { set; get; }
        public string Temprature { set; get; }
        public string Humidity { set; get; }
        public bool SunLight { set; get; }
        public bool Frozen { set; get; }

    }
}
