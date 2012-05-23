using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.ERP
{
    public class ProductCategoryMapper : ClassMap<Clinic.Model.ERP.ProductCategory>
    {
        //private const string schema = "Actions";
        public ProductCategoryMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.ProductCategoryId);
             References(x => x.Parent)
                //.LazyLoad()
               .Nullable();
            Map(x => x.Name)
                .Length(100)
                .Nullable();
            Map(x => x.Note)
                .Length(100)
                .Nullable();

        }
    }

}
