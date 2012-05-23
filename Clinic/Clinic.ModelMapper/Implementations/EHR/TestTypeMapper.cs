using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.EHR
{
    public class TestTypeMapper : ClassMap<Clinic.Model.EHR.TestType>
    {
        //private const string schema = "Actions";
        public TestTypeMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.TestTypeId);          
              Map(x => x.TestName)
                .Length(100)
                .Not.Nullable();
           

        }
    }

}

