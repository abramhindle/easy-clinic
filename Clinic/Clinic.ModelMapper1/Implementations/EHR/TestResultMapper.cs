using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.HR;
using Clinic.Model.ERP;
using Clinic.Model.CRM;

using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.EHR
{
    public class TestResultMapper : ClassMap<Clinic.Model.EHR.TestResult>
    {
        //private const string schema = "Actions";
        public TestResultMapper()
        {
            //  SchemaIs(schema);
            Map(x => x.TestResultId)
                .WithLengthOf(100)
                .Not.Nullable();         
            References(x => x.Order)
                //.LazyLoad()
                .Nullable();
            Map(x => x.Date)
                .Not.Nullable();         
            References(x => x.TestType)
                //.LazyLoad()
                .Nullable();
            Map(x => x.Result)
                .WithLengthOf(100)
                .Nullable();           
            References(x => x.PerformedBy)
                //.LazyLoad()
                .Nullable();
         

        }
    }

}
