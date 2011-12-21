using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.Infrastructure
{
    public class CompStructure
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public Location Location { set; get; }
        public CompStructure Parrent { set; get; }
        public string DepartmentId { set; get; }

    }
}
