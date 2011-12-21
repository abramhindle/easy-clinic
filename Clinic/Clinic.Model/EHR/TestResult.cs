using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.HR;

namespace Clinic.Model.EHR
{
    /// <summary>
    /// X-ray, ultrasound ...
    /// </summary>
    public class TestResult
    {
        public string TestResultId { set; get; }
        public DateTime Date { set; get; }
        public TestType TestType { set; get; }
        public string Result { set; get; }
        public Employee PerformedBy { set; get; }
    }
}
