using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernateEClinic.Model;
using NHibernate;
using NHibernate.Linq;

namespace NHibernateEClinic.LINQModel
{
    public class ModelContext : NHibernateContext
    {
        public ModelContext(ISession session)
            : base(session)
        {
        }

        public IOrderedQueryable<NHibernateEClinic.Model.Action> Actions
        {
            get
            {
                return Session.Linq<NHibernateEClinic.Model.Action>();
            }
        }

        public IOrderedQueryable<User> Users
        {
            get
            {
                return Session.Linq<User>();
            }
        }
        public IOrderedQueryable<Role> Roles
        {
            get
            {
                return Session.Linq<Role>();
            }
        }

       
    }
    
}
