using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;

namespace Clinic.Model.EHR
{
    public class MedicalHistory
    {
        public int SurgicalHistoryId {set;get;}
        public Partner Partner { set; get; }
        public MedicalType Surgical { set; get; }
        public DateTime Date { set; get; }
        public string Report { set; get; }
        public string PerformedBy { set; get; }
        public string Detail { set; get; }

    }
}
