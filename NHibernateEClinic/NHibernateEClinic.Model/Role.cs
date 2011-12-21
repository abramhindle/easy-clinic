using System;
using System.Collections.Generic;
using System.Text;
using NHibernateEClinic.Model.Helper;

namespace NHibernateEClinic.Model
{
    public class Role
    {
        public virtual int RoleId { get; protected set; }
        public virtual string RoleName { get; set; }
      //  public virtual IList<Action> ActionList { get; set; }

        public override int GetHashCode()
        {
            return HashCodeGenerator.GenerateHashCode(RoleId);
        }
        public override bool Equals(object obj)
        {
            return this.IsEqual(obj);
        }

        public override string ToString()
        {
            return this.GetPropertiesInfo();
        }
        public Role()
        {
         //   ActionList = new List<Action>();
        }
    }
}
