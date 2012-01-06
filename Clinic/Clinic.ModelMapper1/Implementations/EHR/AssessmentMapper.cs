using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.EHR
{
    public class AssessmentMapper : ClassMap<Clinic.Model.EHR.Assessment>
    {
        //private const string schema = "Actions";
        public AssessmentMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.AssessmentId);  
             Map(x => x.Code)
                .WithLengthOf(100)
                .Not.Nullable();                 
             Map(x => x.Name)
                .WithLengthOf(100)
                .Nullable();
             Map(x => x.Note)
                .WithLengthOf(100)
                .Nullable();

        }
    }

}
