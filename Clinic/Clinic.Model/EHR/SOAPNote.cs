using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.EHR
{
    public struct SOAPNote
    {
        public string Subjective { set; get; }
        public string Objective { set; get; }
        public string Assertment { set; get; }
        public string Plan { set; get; }
    }
}
