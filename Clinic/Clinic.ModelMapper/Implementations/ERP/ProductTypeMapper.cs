using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;

namespace Clinic.Repository.NHibernate.Mapping.ERP
{
    public class ProductTypeMapper : ClassMap<Clinic.Model.ERP.ProductType>
    {
        //private const string schema = "Actions";
        public ProductTypeMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.ProductTypeId);
            Map(x => x.Name)
                .Length(100)
                .Not.Nullable();

        }
    }

}