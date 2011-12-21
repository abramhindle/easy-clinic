using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;

namespace Clinic.Model.ERP
{
    public class Project
    {
        public int ProjectId { set; get; }
        public Customer Customer { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public bool Deleted { set; get; }

    }
}
