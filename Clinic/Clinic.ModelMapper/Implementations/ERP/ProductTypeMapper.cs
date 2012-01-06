using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;

namespace Clinic.ModelMapper.Implementations.ERP
{
    public class ProductTypeMapper : ClassMap<Clinic.Model.ERP.ProductType>
    {
        //private const string schema = "Actions";
        public ProductTypeMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.ProductTypeId);
            Map(x => x.Name)
                .WithLengthOf(100)
                .Not.Nullable();

        }
    }

}