using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.EHR
{
    public class TestResult
    {
        public string TestResultId { set; get; }
        public TestType TestType { set; get; }
        public string Result { set; get; }
    }
}
