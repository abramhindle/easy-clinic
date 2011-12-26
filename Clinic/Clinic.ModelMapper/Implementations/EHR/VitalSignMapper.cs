using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.EHR
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
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.BloodPressure)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.RespiratoryRate)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.Custom1)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.Custom2)
                    .WithLengthOf(100)
                    .Nullable();

        }
    }

}
