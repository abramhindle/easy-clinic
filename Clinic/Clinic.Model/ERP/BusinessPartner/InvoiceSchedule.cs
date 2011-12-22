using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.ERP.BusinessPartner
{
    /// <summary>
    /// Bill for coporate
    /// </summary>
    public class InvoiceSchedule
    {
        public int InvoiceScheduleId { set; get; }
        public string Name { set; get; }
        public string Note { set; get; }
    }
}
