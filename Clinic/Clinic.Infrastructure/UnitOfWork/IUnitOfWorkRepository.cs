using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Infrastructure.Domain;

namespace Clinic.Infrastructure.UnitOfWork
{
    public interface IUnitOfWorkRepository
    {
        void PersistCreationOf(IAggregateRoot entity);
        void PersistUpdateOf(IAggregateRoot entity);
        void PersistDeletionOf(IAggregateRoot entity);
    }
}
