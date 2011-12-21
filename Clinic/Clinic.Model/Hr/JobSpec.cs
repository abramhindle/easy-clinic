using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.HR
{
    public class JobSpec
    {
        public int JobSpecId { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Duties { set; get; }
    }
}
