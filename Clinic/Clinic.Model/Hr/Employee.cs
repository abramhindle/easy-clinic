using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.Infrastructure;

namespace Clinic.Model.HR
{
    public class Employee
    {
        public int EmpNum { set; get; }
        public string EmpId { set; get; }
        public string FirstName { set; get; }
        public string MidName { set; get; }
        public string LastName { set; get; }
        public string Nick { set; get; }
        public bool Smoker { set; get; }
        public string ethenic_race_code { set; get; }
        public DateTime BirthDay { set; get; }
        public int Gender { set; get; }
        public int MeritalStatus { set; get; }
        public JobTitle JobTitle { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
    }
}
