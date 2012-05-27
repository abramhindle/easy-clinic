using System.Collections;
using System.Threading;
using NHibernate;

namespace Clinic.Repository.NHibernate.SessionStorage
{
    public class ThreadSessionStorageContainer : ISessionStorageContainer
    {
        private static readonly Hashtable NhSessions = new Hashtable();

        public ISession GetCurrentSession()
        {
            ISession nhSession = null;

            if (NhSessions.Contains(GetThreadName()))
                nhSession = (ISession)NhSessions[GetThreadName()];

            return nhSession;
        }

        public void Store(ISession session)
        {
            if (NhSessions.Contains(GetThreadName()))
                NhSessions[GetThreadName()] = session;
            else
                NhSessions.Add(GetThreadName(), session);
        }

        private static string GetThreadName()
        {
            return Thread.CurrentThread.Name;
        }
    }

}
