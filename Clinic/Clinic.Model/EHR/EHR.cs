using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;

namespace Clinic.Model.EHR
{
    /// <summary>
    /// Electronic Health Record
    /// </summary>
    public class EHR
    {
        public int EHRId { set; get; }
        public Customer Partner { set; get; }

        public List<MedicalHistory> MedicalHistories { set; get; } //first time only, update directly
        public List<MedicalCounter> MedicalCounters { set; get; } //eachtime come to office, cumulative update

    }
}
