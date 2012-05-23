using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;

namespace Clinic.Repository.NHibernate.Mapping.ERP
{
    public class ProtectionMapper : ClassMap<Clinic.Model.ERP.Protection>
    {
        //private const string schema = "Actions";
        public ProtectionMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.ProtectionId);
            Map(x => x.Temprature)
                .Length(100)
                .Nullable();
            Map(x => x.Humidity)
                .Length(100)
                .Nullable();
            Map(x => x.SunLight)
                .Nullable();
            Map(x => x.Frozen)
                .Nullable();
        }
    }

}