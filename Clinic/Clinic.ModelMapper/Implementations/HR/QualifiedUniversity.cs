using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.HR
{
    /// <summary>
    ///  Master of Science/Engineering/NationalUniversity
    /// </summary>
    public class QualifiedUniversity
    {
        public int QualifiedUniversityId { set; get; }
        public string UniversityName { set; get; }
        public string Degree { set; get; }
        public string Course { set; get; }
    }
}
