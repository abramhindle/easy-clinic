using System;
using System.Collections.Generic;
using System.Text;
using NHibernateEClinic.Model.Helper;

namespace NHibernateEClinic.Model
{
    public class User
    {
        public virtual int UserId { get; protected set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string Email { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Address { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual bool IsLogin { get; set; }

       // public virtual IList<Role> RoleList { get; set; }
        public override int GetHashCode()
        {
            return HashCodeGenerator.GenerateHashCode(UserId);
        }
        public override bool Equals(object obj)
        {
            return this.IsEqual(obj);
        }

        public override string ToString()
        {
            return this.GetPropertiesInfo();
        }

        public User()
        {
         //   RoleList = new List<Role>();
        }
    }
}
