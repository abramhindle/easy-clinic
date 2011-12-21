using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.HR
{
    public class AttendanceRecord
    {
        public int AttendanceRecordId { set; get; }
        public Employee Employee { set; get; }
        public DateTime PuchInTime { set; get; }
        public string PuchInNote { set; get; }
        public DateTime PuchOutTime { set; get; }
        public string PuchOutNote { set; get; }
        public string Status { set; get; }

    }
}
