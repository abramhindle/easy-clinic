using System;
using NHibernate;
using NHibernateEClinic.ModelMapper;
using Xunit;

namespace NHibernateEClinic.Tests
{
    public abstract class TestBase : IDisposable
    {
        #region Properties
        private ISession session;
        protected ISession Session
        {
            get
            {
                if (session == null)
                {
                    session = ModelBuilder.GetSessionFactory().OpenSession();
                }
                return session;
            }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            if (session != null)
            {
                session.Dispose();
            }
        }

        #endregion

        #region Abstract Test Methods
        public abstract void Test_Retrieve_Entity_With_EntityID_Equals_To_X_Should_Return_One_Item();

        public abstract void Test_Retrieve_Entity_With_EntityID_Equals_To_X_Should_Return_Null();

        public abstract void Test_Retrieve_Entity_With_EntityID_Less_Than_X_Should_Return_No_More_Than_Y_Items();

        public abstract void Test_Sorting_Ascending();

        public abstract void Test_Sorting_Descending();

        public abstract void Test_Simple_Projection();

        public abstract void Test_Complex_Projection();

        public abstract void Test_Complex_Projection_And_Entity_Projection();

        public abstract void Test_Paging_Simple();

        public abstract void Test_Paging_Complex();

        public abstract void Test_Aggregates();

        public abstract void Test_AddItem();

        public abstract void Test_UpdateItem();

        public abstract void Test_DeleteItem();
        #endregion

    }
    public class TestFoo
    {
        public static int GenerateHashCode(params object[] keys)
        {
            int hash = 17;

            foreach (var item in keys)
            {
                int itemHashCode;
                if (item == null)
                {
                    itemHashCode = 1;
                }
                else
                {
                    itemHashCode = item.GetHashCode();
                }
                hash = hash * 23 + itemHashCode;
            }

            return hash;
        }
    }
}
