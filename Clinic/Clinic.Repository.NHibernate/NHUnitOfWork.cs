using System;
using Clinic.Infrastructure.Domain;
using Clinic.Infrastructure.UnitOfWork;
using Clinic.Repository.NHibernate.SessionStorage;
using NHibernate;

namespace Clinic.Repository.NHibernate
{
    public class NHUnitOfWork : IUnitOfWork
    {
        public void RegisterAmended(IAggregateRoot entity,
                                    IUnitOfWorkRepository unitofWorkRepository)
        {
            SessionFactory.GetCurrentSession().SaveOrUpdate(entity);
        }

        public void RegisterNew(IAggregateRoot entity,
                                IUnitOfWorkRepository unitofWorkRepository)
        {
            SessionFactory.GetCurrentSession().Save(entity);
        }

        public void RegisterRemoved(IAggregateRoot entity,
                                    IUnitOfWorkRepository unitofWorkRepository)
        {
            SessionFactory.GetCurrentSession().Delete(entity);
        }

        public void Commit()
        {
            using (ITransaction transaction =
                           SessionFactory.GetCurrentSession().BeginTransaction())
            {
                try
                { transaction.Commit(); }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }

}
