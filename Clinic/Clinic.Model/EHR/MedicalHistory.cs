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
        public Customer Partner { set; get; }
        public MedicalType MedicalType { set; get; }
        public DateTime Date { set; get; }
        public string Detail { set; get; }
        public Employee PerformedBy { set; get; }      

    }
}
