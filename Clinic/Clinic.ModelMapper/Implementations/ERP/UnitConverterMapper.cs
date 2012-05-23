using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace Clinic.Repository.NHibernate.Mapping.ERP
{
    public class UnitConverterMapper : ClassMap<Clinic.Model.ERP.UnitConverter>
    {
        //private const string schema = "Actions";
        public UnitConverterMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.UnitConverterId);
            References(x => x.Source)
                //.LazyLoad()
              .Nullable();
            References(x => x.Target)
                //.LazyLoad()
              .Nullable();
            Map(x => x.Value)
                .Nullable();
        }
    }

}

