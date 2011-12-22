using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;

namespace Clinic.Model.Infrastructure
{
    public class AuditInfo
    {
        public DateTime CreateDate { set; get; }
        public Partner CreateBy { set; get; }
        public DateTime LastModified { set; get; }
        public Partner ModifiedBy { set; get; }

    }
}
