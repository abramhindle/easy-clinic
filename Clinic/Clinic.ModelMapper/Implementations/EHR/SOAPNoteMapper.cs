using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.EHR
{
    public class SOAPNoteMapper : ClassMap<Clinic.Model.EHR.SOAPNote>
    {
        //private const string schema = "Actions";
        public SOAPNoteMapper()
        {
            //  SchemaIs(schema);           
              Map(x => x.Subjective)
                .Length(100)
                .Nullable();
              Map(x => x.Objective)
                .Length(100)
                .Nullable();
              Map(x => x.Assertment)
                .Length(100)
                .Nullable();
              Map(x => x.Plan)
                .Length(100)
                .Nullable();
           

        }
    }

}
