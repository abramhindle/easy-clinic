using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;

namespace Clinic.Repository.NHibernate.Mapping.ERP
{
    public class ServiceMapper : ClassMap<Clinic.Model.ERP.Service>
    {
        //private const string schema = "Actions";
        public ServiceMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.ServiceId);
            Map(x => x.Name)
                .Length(100)
                .Nullable();
            References(x => x.ServiceType)
                //.LazyLoad()
              .Nullable();
            References(x => x.Unit)
                //.LazyLoad()
              .Nullable();
            Map(x => x.Price)
                .Nullable();
            Map(x => x.Note)
                .Length(100)
                .Nullable();
        }
    }

}
