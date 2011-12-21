using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.Infrastructure;

namespace Clinic.Model.HR
{
    public class TimeSheetActionLog
    {
        public int TimeSheetActionLogId { set; get; }
        public TimeSheet TimeSheet { set; get; }
        public string Action { set; get; }
        public string Note { set; get; }
        public DateTime Date { set; get; }
        public User PerformedBy { set; get; }
    }
}
