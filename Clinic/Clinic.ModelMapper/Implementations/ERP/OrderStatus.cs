using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.ERP
{
    public class OrderStatus
    {
        public int OrderStatusId { set; get; }
        public LineItem LineItem { set; get; }
        public DateTime TimeStamp { set; get; }
        public string Status { set; get; }
    }
}
