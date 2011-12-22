using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.HR;

namespace Clinic.Model.EHR
{
    public class AssessmentAndPlan
    {
        public int AssessmentAndPlanId { set; get; }
        public Assessment Assessment { set; get; }
        public Plan Plan { set; get; }
        public Employee CreatedBy { set; get; }
        public string Name { set; get; }                
    }
}
