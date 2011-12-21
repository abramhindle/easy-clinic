using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace NHibernateEClinic.Tests
{
    class Program
    {
        public static void Main(string[] args)
        {
          ActionTests a = new ActionTests();
           // AddressTests a = new AddressTests();
            a.Test_Retrieve_Entity_With_EntityID_Equals_To_X_Should_Return_One_Item();
        }
    }
}

