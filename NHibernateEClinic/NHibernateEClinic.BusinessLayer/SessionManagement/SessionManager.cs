using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using System.Web;
using NHibernateEClinic.ModelMapper;
using NHibernate.Context;

namespace NHibernateEClinic.BusinessLayer.SessionManagement
{
    //for more info check:http://pwigle.wordpress.com/2008/11/21/nhibernate-session-handling-in-aspnet-the-easy-way/
    public static class SessionManager
    {
        internal static ISession DataSession
        {
            get
            {
                ISession output = ModelBuilder.GetSessionFactory().GetCurrentSession();
                return output;
            }
        }

        public static void OpenSession()
        {
            ManagedWebSessionContext.Bind(HttpContext.Current, ModelBuilder.GetSessionFactory().OpenSession());
        }

        public static void CloseSession()
        {
            ISession session = ManagedWebSessionContext.Unbind(HttpContext.Current, ModelBuilder.GetSessionFactory());
            if (session != null)
            {
                if (session.Transaction != null && session.Transaction.IsActive)
                {
                    session.Transaction.Rollback();
                }
                else
                {
                    session.Flush();
                }
                session.Close();
            }
        }
    }

}
