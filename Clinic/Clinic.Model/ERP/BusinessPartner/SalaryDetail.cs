using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.Infrastructure;

namespace Clinic.Model.HR
{
    public class SalaryDetail
    {
        public SalaryGrade SalaryGrade { set; get; }
        public Currency Currency { set; get; }
        public int MinValue { set; get; }
        public int MaxValue { set; get; }
        public int StepValue { set; get; }
    }
}
