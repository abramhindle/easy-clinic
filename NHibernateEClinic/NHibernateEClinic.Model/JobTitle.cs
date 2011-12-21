using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.Infrastructure
{
    public class JobTitle
    {
        public string JobTitleId { set; get; }
        public string Name { set; get; }
        public string Note { set; get; }
        public bool IsActive { set; get; }
        public SalaryGrade SalaryGrade { set; get; }
        public int JobSpecId { set; get; }
    }
}
