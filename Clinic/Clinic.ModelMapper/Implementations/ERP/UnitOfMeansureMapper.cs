using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace Clinic.Repository.NHibernate.Mapping.ERP
{
    public class UnitOfMeansureMapper : ClassMap<Clinic.Model.ERP.UnitOfMeansure>
    {
        //private const string schema = "Actions";
        public UnitOfMeansureMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.UnitOfMeansureId);
            Map(x => x.Name)
                .Length(100)
                .Nullable();
            Map(x => x.EDICode)
                .Length(100)
                .Nullable();
            Map(x => x.Note)
                .Length(100)
                .Nullable();
            Map(x => x.IsDefault)
                .Nullable();

        }
    }

}
