using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;
using Clinic.Model.ERP;
using Clinic.Model.HR;

namespace Clinic.Model.EHR
{
    /// <summary>
    /// Each time come to office http://www.ehrmarket.com/blog/wp-content/uploads/NextGen_mainview_large.jpg
    /// </summary>
    public class MedicalCounter
    {
        public int MedicalCounterId { set; get; }
        public Partner Partner { set; get; }
        public Employee HandleBy { set; get; }
        public DateTime Date { set; get; }
        public int IsSmoke { set; get; } //yes, quit, no

        public string Complain { set; get; }
        public List<HPI> HPI { set; get; } //history of present illness
        public string PhysicalExamization { set; get; }
        public string AssessmentAndPlan { set; get; } //progress note
        
        public VitalSign VitalSign { set; get; }
        public List<Order> OrdersAndPrescriptions { set; get; }
        public List<TestResult> TestResult { set; get; }        
        public List<SOAPNote> ProgressNote { set; get; }
        public Employee Referer { set; get; }
    }
}
