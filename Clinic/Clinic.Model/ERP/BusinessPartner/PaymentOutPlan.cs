using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.Infrastructure;

namespace Clinic.Model.ERP.BusinessPartner
{
    public class PaymentOutPlan
    {
        public int PaymentOutPlanId { set; get; }
        public string PaymentMethod { set; get; }
        public DateTime DueDate { set; get; }
        public decimal ExpectedAmount { set; get; }
        public decimal Paid { set; get; }
        public decimal OutStanding { set; get; }
        public Currency Currency { set; get; }
        public List<PaymentOutPlan> History { set; get; }

    }
}
