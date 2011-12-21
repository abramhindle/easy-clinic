using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.CRM
{
    public class Partner
    {
        public int CustomerId { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public bool Deleted { set; get; }
    }
}
