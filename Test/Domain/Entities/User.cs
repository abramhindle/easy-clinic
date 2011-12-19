using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class User
    {
        public virtual int Id { get; protected set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string Email { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Address { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual bool IsLogin { get; set; }

        public virtual IList<Role> RoleList { get; set; }

        public User()
        {
            RoleList = new List<Role>();
        }
    }
}
