using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.ERP;
using Clinic.Model.Inventories;

namespace Clinic.Model.EHR
{
    public class Plan
    {
        public int PlanId { set; get; }
        public List<Service> Services { set; get; }
        public List<Product> Products { set; get; }
    }
}
