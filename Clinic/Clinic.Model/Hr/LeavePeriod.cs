using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.HR
{
    public class LeavePeriod
    {
        public int LeavePeriodId { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
    }
}
