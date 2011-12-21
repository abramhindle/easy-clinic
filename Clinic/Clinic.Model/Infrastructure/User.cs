using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.HR;

namespace Clinic.Model.Infrastructure
{
    public class User
    {
        public string UserName { set; get; }
        public string Password { set; get; }
        public string PasswordHash { set; get; }
        public bool IsAdmin { set; get; }
        public string Name { set; get; }
        public bool Deleted { set; get; }

        public JobTitle Title { set; get; }
        public CompStructure Department { set; get; }
        public string Phone { set; get; }
        public string Mobile { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public string City { set; get; }
        public string Country { set; get; }
        public string ZipCode { set; get; }


        public DateTime DateEnter { set; get; }
        public DateTime DateModify { set; get; }
        public User ModifiedBy { set; get;}
        public User CreatedBy { set; get; }

        public Employee Employee { set; get; }
        public UserGroup UserGroup { set; get; }
    }
}
