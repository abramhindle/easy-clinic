using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.EHR
{
    /// <summary>
    /// Decese assessment ICD10
    /// </summary>
    public class Assessment
    {
        public int AssessmentId { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string Note { set; get; }

    }
}
