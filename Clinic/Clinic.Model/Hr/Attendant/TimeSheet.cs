using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.HR
{
    public class TimeSheet
    {
        public int TimeSheetId { set; get; }
        public Employee Employee { set; get; }
        public string State { set; get; } //submit
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
    }
}
