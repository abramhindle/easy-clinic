using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.Infrastructure;


namespace Clinic.Model.CRM
{
    public class Customer
    {
        public int CustomerId { set; get; }
        public string CustomerCode { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public CustomerType PartnerType { set; get; }
        public Location Location { set; get; }
        public bool Deleted { set; get; }
    }
}
