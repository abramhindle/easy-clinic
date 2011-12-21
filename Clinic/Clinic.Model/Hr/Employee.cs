using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.Infrastructure;

namespace Clinic.Model.HR
{
    public class Employee
    {
        public int EmployeeId { set; get; }
        public string EmployeeNo { set; get; }
        public string FirstName { set; get; }
        public string MidName { set; get; }
        public string LastName { set; get; }
        public string Nick { set; get; }
        public bool Smoker { set; get; }
        public EthernicRace EthernicRace { set; get; }
        public DateTime BirthDay { set; get; }
        public int Gender { set; get; }
        public int MeritalStatus { set; get; }
        
        public string Address1 { set; get; }
        public string Address2 { set; get; }
        public District District { set; get; }        
        public Country National { set; get; }
        public Province Province { set; get; }
        public string ZipCode { set; get; }

        public string Phone { set; get; }
        public string HomePhone { set; get; }
        public string Mobile { set; get; }
        public string Email { set; get; }
        public string OtherEmail { set; get; }
        public string TerminatedReason { set; get; }
        public DateTime TerminatedDate { set; get; }

        public JobTitle JobTitle { set; get; }        
        public CompStructure WorkStation { set; get; }
        public SalaryGrade SalaryGrade { set; get; }
        public DateTime JoinDate { set; get; }

        public string Custom1 { set; get; }
        public string Custom2 { set; get; }
        public string Custom3 { set; get; }
        public string Custom4 { set; get; }
        public string Custom5 { set; get; }
        public string Custom6 { set; get; }
        public string Custom7 { set; get; }
        public string Custom8 { set; get; }
        public string Custom9 { set; get; }

    }
}
