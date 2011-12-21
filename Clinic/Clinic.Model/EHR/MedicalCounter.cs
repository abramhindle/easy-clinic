using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;

namespace Clinic.Model.EHR
{
    public class MedicalCounter
    {
        public int MedicalCounterId { set; get; }
        public Partner Partner { set; get; }
        public DateTime Date { set; get; }
        public string Complain { set; get; }
        public string PhysicalExamization { set; get; }
        public string AssessmentAndPlan { set; get; }
        
        public VitalSign VitalSign { set; get; }
        public List<TestResult> TestResult { set; get; }
    }
}
