using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.HR
{
    public class MembershipDetail
    {
        public int MembershipDetailId { set; get; }
        public MembershipType MembershipType { set; get; }
        public string Name { set; get; }

    }
}
