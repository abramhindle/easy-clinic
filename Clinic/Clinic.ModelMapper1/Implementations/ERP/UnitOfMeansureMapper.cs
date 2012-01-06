using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace Clinic.ModelMapper.Implementations.ERP
{
    public class UnitOfMeansureMapper : ClassMap<Clinic.Model.ERP.UnitOfMeansure>
    {
        //private const string schema = "Actions";
        public UnitOfMeansureMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.UnitOfMeansureId);
            Map(x => x.Name)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.EDICode)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.Note)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.IsDefault)
                .Nullable();

        }
    }

}
