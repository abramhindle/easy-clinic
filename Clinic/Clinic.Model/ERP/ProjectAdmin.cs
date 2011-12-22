using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.HR;
using Clinic.Model.CRM;

namespace Clinic.Model.ERP
{
    public class ProjectAdmin
    {
        public int ProjectAdminId { set; get; }
        public Partner Employee { set; get; }
    }
}
