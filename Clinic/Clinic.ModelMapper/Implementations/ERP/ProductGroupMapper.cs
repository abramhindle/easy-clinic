using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.ERP
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
                .Length(100)
                .Nullable();
            Map(x => x.Note)
                .Length(100)
                .Nullable();
            References(x => x.Discount)
                //.LazyLoad()
               .Nullable();
            Map(x => x.Tax)
                .Nullable();

        }
    }

}
