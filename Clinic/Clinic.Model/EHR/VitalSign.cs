using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.EHR
{
    /// <summary>
    /// Lam san http://www.ehrmarket.com/blog/wp-content/uploads/NextGen_mainview_large.jpg
    /// </summary>
    public class VitalSign
    {        
        public int VitalSignId { set; get; }
        public MedicalCounter MedicalCounter { set; get; }
        public int Temperature { set; get; }
        public string PulseRate { set; get; }
        public string BloodPressure { set; get; }
        public string RespiratoryRate { set; get; }
        public string Custom1 { set; get; }
        public string Custom2 { set; get; }
    }
}
