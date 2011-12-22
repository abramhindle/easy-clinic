using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.HR
{
    public class JobShift
    {
        public int JobShiftId { set; get; }
        public string Name { set; get; }
        public decimal Duration { set; get; } //hours per day
    }
}
