using System;
using System.Collections.Generic;
using System.Text;
using NHibernateEClinic.Model.Helper;

namespace NHibernateEClinic.Model
{
    public class Action
    {
        public virtual int ActionID { get; protected set; }
        public virtual string ActionName { get; set; }
        public override int GetHashCode()
        {
            return HashCodeGenerator.GenerateHashCode(ActionID);
        }
        public override bool Equals(object obj)
        {
            return this.IsEqual(obj);
        }

        public override string ToString()
        {
            return this.GetPropertiesInfo();
        }
    }
}
