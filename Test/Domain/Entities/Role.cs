using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Role
    {
        public virtual int Id { get; protected set; }
        public virtual string RoleName { get; set; }
        public virtual IList<Action> ActionList { get; set; }

        public Role()
        {
            ActionList = new List<Action>();
        }
    }
}
