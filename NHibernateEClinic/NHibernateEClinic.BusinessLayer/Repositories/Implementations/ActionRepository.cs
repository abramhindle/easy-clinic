using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernateEClinic.Model;
using NHibernateEClinic.LINQModel;
using NHibernateEClinic.BusinessLayer.SessionManagement;
using NHibernateEClinic.BusinessLayer.Utils;

namespace NHibernateEClinic.BusinessLayer.Repositories.Implementations
{
    public class ActionRepository : IActionRepository
    {
        #region IActionRepository Members

        public IList<NHibernateEClinic.Model.Action> ListActions(int startRowIndex, int pageSize, string sortExpression)
        {
            var mc = new ModelContext(SessionManager.DataSession);
            var output = mc.Actions.SortBy(sortExpression).Skip(startRowIndex).Take(pageSize);

            return output.ToList();
        }

        public void EditAction(int actionId, string actionName)
        {
            var mc = new ModelContext(SessionManager.DataSession);
            var action = SessionManager.DataSession.Get<NHibernateEClinic.Model.Action>(actionId);

            action.ActionName = actionName;

            SessionManager.DataSession.Update(action);
            SessionManager.DataSession.Flush();
        }

        public int ActionsCount()
        {
            var mc = new ModelContext(SessionManager.DataSession);
            var output = mc.Actions.Count();

            return output;
        }

        public void DeleteAction(int actionId)
        {
            var mc = new ModelContext(SessionManager.DataSession);
            var action = SessionManager.DataSession.Load<NHibernateEClinic.Model.Action>(actionId);

            SessionManager.DataSession.Delete(action);
            SessionManager.DataSession.Flush();
        }

        public void InsertAction(string actionName)
        {
            var action = new NHibernateEClinic.Model.Action();

            action.ActionName = actionName;

            SessionManager.DataSession.Save(action);
            SessionManager.DataSession.Flush();
        }

        #endregion
    }
}
