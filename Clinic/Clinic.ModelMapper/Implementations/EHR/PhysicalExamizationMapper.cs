using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.EHR
{
    public class PhysicalExamizationMapper : ClassMap<Clinic.Model.EHR.PhysicalExamization>
    {
        //private const string schema = "Actions";
        public PhysicalExamizationMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.PhysicalExamizationId);          
         
            Map(x => x.Name)
                .Length(100)
                .Not.Nullable();
           Map(x => x.Detail)
                .Length(100)
                .Nullable();
           

        }
    }

}

