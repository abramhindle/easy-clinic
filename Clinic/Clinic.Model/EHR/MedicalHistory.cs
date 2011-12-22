using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;
using Clinic.Model.HR;

namespace Clinic.Model.EHR
{
    /// <summary>
    /// History of medical 
    /// </summary>
    public class MedicalHistory
    {
        public int MedicalHistoryId { set; get; }
        public Partner Partner { set; get; }
        public MedicalType MedicalType { set; get; }
        public DateTime Date { set; get; }
        public string Detail { set; get; }
        public Partner PerformedBy { set; get; }      

    }
}
