using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.Infrastructure;

namespace Clinic.Model.HR
{
    /// <summary>
    /// Company structure: describe the logical structure of company
    /// </summary>
    public class CompStructure
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public Location Location { set; get; }
        public CompStructure Parrent { set; get; }
        public string DepartmentId { set; get; }

    }
}
