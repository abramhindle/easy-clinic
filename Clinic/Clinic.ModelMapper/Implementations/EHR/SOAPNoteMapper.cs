using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.EHR
{
    public class SOAPNoteMapper : ClassMap<Clinic.Model.EHR.SOAPNote>
    {
        //private const string schema = "Actions";
        public SOAPNoteMapper()
        {
            //  SchemaIs(schema);           
              Map(x => x.Subjective)
                .WithLengthOf(100)
                .Nullable();
              Map(x => x.Objective)
                .WithLengthOf(100)
                .Nullable();
              Map(x => x.Assertment)
                .WithLengthOf(100)
                .Nullable();
              Map(x => x.Plan)
                .WithLengthOf(100)
                .Nullable();
           

        }
    }

}
