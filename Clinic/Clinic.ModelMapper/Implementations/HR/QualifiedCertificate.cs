using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.HR
{
    /// <summary>
    /// Certification: CCNA 990/1000
    /// </summary>
    public class QualifiedCertificate
    {
        public int QualifiedCertificateId { set; get; }
        public string Name { set; get; }
        public string Grade { set; get; }
    }
}
