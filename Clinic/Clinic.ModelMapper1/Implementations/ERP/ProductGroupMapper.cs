using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.ERP
{
    public class ProductGroupMapper : ClassMap<Clinic.Model.ERP.ProductGroup>
    {
        //private const string schema = "Actions";
        public ProductGroupMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.ProductGroupId);
            References(x => x.ProductIndustry)
                //.LazyLoad()
               .Nullable();
            Map(x => x.Name)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.Note)
                .WithLengthOf(100)
                .Nullable();
            References(x => x.Discount)
                //.LazyLoad()
               .Nullable();
            Map(x => x.Tax)
                .Nullable();

        }
    }

}
