using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernateEClinic.BusinessLayer.Repositories
{
    
    public interface IActionRepository
    {
        IList<NHibernateEClinic.Model.Action> ListActions(int startRowIndex, int pageSize, string sortExpression);
        void EditAction(int actionId, string actionName);
        int ActionsCount();
        void DeleteAction(int actionId);
        void InsertAction(string actionName);
    }
}
