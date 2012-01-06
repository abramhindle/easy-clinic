using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;

namespace Clinic.ModelMapper.Implementations.ERP
{
    public class ServiceMapper : ClassMap<Clinic.Model.ERP.Service>
    {
        //private const string schema = "Actions";
        public ServiceMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.ServiceId);
            Map(x => x.Name)
                .WithLengthOf(100)
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
                .WithLengthOf(100)
                .Nullable();
        }
    }

}
