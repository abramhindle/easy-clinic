using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.EHR
{
    public class HPIMapper : ClassMap<Clinic.Model.EHR.HPI>
    {
        //private const string schema = "Actions";
        public HPIMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.PHIId);          
            Map(x => x.Concern)
            .WithLengthOf(100)
            .Nullable();
           Map(x => x.OnSet)
            .WithLengthOf(100)
            .Nullable();
            Map(x => x.Duration)
            .WithLengthOf(100)
            .Nullable();
            Map(x => x.Freequency)
            .WithLengthOf(100)
            .Nullable();
            Map(x => x.Severity)
            .WithLengthOf(100)
            .Nullable();
            Map(x => x.Status)
            .WithLengthOf(100)
            .Nullable();

        }
    }

}
