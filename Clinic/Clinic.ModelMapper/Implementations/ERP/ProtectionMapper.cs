using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;

namespace Clinic.ModelMapper.Implementations.ERP
{
    public class ProtectionMapper : ClassMap<Clinic.Model.ERP.Protection>
    {
        //private const string schema = "Actions";
        public ProtectionMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.ProtectionId);
            Map(x => x.Temprature)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.Humidity)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.SunLight)
                .Nullable();
            Map(x => x.Frozen)
                .Nullable();
        }
    }

}