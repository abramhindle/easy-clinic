using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace Clinic.ModelMapper.Implementations.ERP
{
    public class ProductIndustryMapper : ClassMap<Clinic.Model.ERP.ProductIndustry>
    {
        //private const string schema = "Actions";
        public ProductIndustryMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.IndustryId);
            Map(x => x.Name)
                .WithLengthOf(100)
                .Not.Nullable();
            Map(x => x.Note)
                .WithLengthOf(100)
                .Nullable();

        }
    }

}