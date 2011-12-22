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
        public DateTime Date { set; get; }
        public Employee HandleBy { set; get; }        
        public Employee Referer { set; get; }
                
        public List<HPI> ChiefComplain { set; get; } //history of present illness
        public List<PhysicalExamization> PhysicalExamization { set; get; } 
        public List<Order> OrdersAndPrescriptions { set; get; }
        public List<TestResult> TestResult { set; get; }        
        public List<AssessmentAndPlan> AssessmentAndPlan { set; get; } //progress note               
        public List<SOAPNote> ProgressNote { set; get; }        
    }
}
