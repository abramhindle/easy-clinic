using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.EHR
{
    public class VitalSignMapper : ClassMap<Clinic.Model.EHR.VitalSign>
    {
        //private const string schema = "Actions";
        public VitalSignMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.VitalSignId);          
            References(x => x.MedicalCounter)
                //.LazyLoad()
               .Nullable();
            Map(x => x.Temperature)
                .Nullable();
            Map(x => x.PulseRate)
                .Length(100)
                .Nullable();
            Map(x => x.BloodPressure)
                .Length(100)
                .Nullable();
            Map(x => x.RespiratoryRate)
                .Length(100)
                .Nullable();
            Map(x => x.Custom1)
                .Length(100)
                .Nullable();
            Map(x => x.Custom2)
                    .Length(100)
                    .Nullable();

        }
    }

}
