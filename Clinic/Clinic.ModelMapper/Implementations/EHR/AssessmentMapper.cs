using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.EHR
{
    public class AssessmentMapper : ClassMap<Clinic.Model.EHR.Assessment>
    {
        //private const string schema = "Actions";
        public AssessmentMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.AssessmentId);  
             Map(x => x.Code)
                .Length(100)
                .Not.Nullable();                 
             Map(x => x.Name)
                .Length(100)
                .Nullable();
             Map(x => x.Note)
                .Length(100)
                .Nullable();

        }
    }

}
