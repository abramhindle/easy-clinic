using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using NHibernateEClinic.LINQModel;


namespace NHibernateEClinic.Tests
{
    public class ActionTests : TestBase
    {
        [Fact]
        public override void Test_Retrieve_Entity_With_EntityID_Equals_To_X_Should_Return_One_Item()
        {
            using (var context = new ModelContext(Session))
            {
                int actionID = 1;
                var result = (from action in context.Actions
                              where action.ActionID == actionID
                              select action).SingleOrDefault();
                Assert.NotNull(result);
                Assert.Equal(result.ActionID, actionID);
                Console.WriteLine(result.ActionID + " " + result.ActionName);
            }
        }
        [Fact]
        public override void Test_Retrieve_Entity_With_EntityID_Equals_To_X_Should_Return_Null()
        {
        
        }

        [Fact]
        public override void Test_Retrieve_Entity_With_EntityID_Less_Than_X_Should_Return_No_More_Than_Y_Items()
        {
        
        }

        [Fact]
        public override void Test_Sorting_Ascending()
        {
        
        }

        [Fact]
        public override void Test_Sorting_Descending()
        {
                    
        }

        [Fact]
        public override void Test_Simple_Projection()
        {
            
        }

        [Fact]
        public override void Test_Complex_Projection()
        {
            
        }

        [Fact(Skip = "Projections over Entities is not working yet")]
        public override void Test_Complex_Projection_And_Entity_Projection()
        {
            
        }

        [Fact]
        public override void Test_Paging_Simple()
        {
            
        }

        [Fact]
        public override void Test_Paging_Complex()
        {
            
        }

        [Fact]
        public override void Test_Aggregates()
        {
            
        }

        [Fact]
        public override void Test_AddItem()
        {
            
        }

        [Fact]
        public override void Test_UpdateItem()
        {
          
        }

        [Fact]
        public override void Test_DeleteItem()
        {
            
        }
    }
}
