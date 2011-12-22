using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;

namespace Clinic.Model.HR
{
    public class TimeSheet
    {
        public int TimeSheetId { set; get; }
        public Partner Employee { set; get; }
        public string State { set; get; } //submit
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
    }
}
