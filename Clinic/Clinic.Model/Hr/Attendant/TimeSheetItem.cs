using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.ERP;

namespace Clinic.Model.HR
{
    public class TimeSheetItem
    {
        public int TimeSheetItemId { set; get; }
        public TimeSheet TimeSheet { set; get; }
        public DateTime Date { set; get; }
        public long Duration { set; get; }
        public string Note { set; get; }
        public ProjectActivity ProjectActivity { set; get; }
        public Project Project { set; get; }
        public Employee Employee { set; get; }
    }
}
