using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.EHR
{
    public class HPIMapper : ClassMap<Clinic.Model.EHR.HPI>
    {
        //private const string schema = "Actions";
        public HPIMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.PHIId);          
            Map(x => x.Concern)
            .Length(100)
            .Nullable();
           Map(x => x.OnSet)
            .Length(100)
            .Nullable();
            Map(x => x.Duration)
            .Length(100)
            .Nullable();
            Map(x => x.Freequency)
            .Length(100)
            .Nullable();
            Map(x => x.Severity)
            .Length(100)
            .Nullable();
            Map(x => x.Status)
            .Length(100)
            .Nullable();

        }
    }

}
