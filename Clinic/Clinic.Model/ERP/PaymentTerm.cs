using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;

namespace Clinic.Model.ERP
{
    /// <summary>
    /// Allow payment to be schedule by time
    /// </summary>
    public class PaymentTerm
    {
        public int PaymentTermId { set; get; }
        public Partner Partner { set; get; }
        public string Name { set; get; }
        public string Note { set; get; }
        public int OffsetMonthDue { set; get; }
        public int OverDuePaymentDaysRule { set; get; }
        public int OverDuePaymentDayRule { set; get; } //Mon/Tue/
        public List<DateTime> FixedDueDate { set; get; }
    }
}
