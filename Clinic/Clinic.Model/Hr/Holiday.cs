using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.HR
{
    public class Holiday
    {
        public int HolidayId { set; get; }
        public string Note { set; get; }
        public DateTime Date { set; get; }
        public int Recurring { set; get; }
        public int Length { set; get; }
             
    }
}
