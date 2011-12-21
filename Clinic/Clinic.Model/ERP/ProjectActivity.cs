using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.ERP
{
    public class ProjectActivity
    {
        public int ProjectActivityId { set; get; }
        public Project Project { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
    }
}
