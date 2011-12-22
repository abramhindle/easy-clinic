using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;

namespace Clinic.Model.HR
{
    public class LeaveRequest
    {
        public int LeaveRequestId { set; get; }
        public LeaveType LeaveType { set; get; }
        public LeavePeriod LeavePeriod { set; get; }
        public Partner Employee { set; get; }
        public string Name { set; get; }
        public string Note { set; get; }
        public DateTime DateApply { set; get; }
    }
}
