using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.EHR
{
    /// <summary>
    /// General(blood presure/heart rate/ ..) and Specific(lung/heart/eye/oral)
    /// </summary>
    public class PhysicalExamization
    {
        public int PhysicalExamizationId { set; get; }
        public string Name { set; get; }
        public string Detail { set; get; }

    }
}
