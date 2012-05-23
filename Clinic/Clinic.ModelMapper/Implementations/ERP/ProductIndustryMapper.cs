using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace Clinic.Repository.NHibernate.Mapping.ERP
{
    public class ProductIndustryMapper : ClassMap<Clinic.Model.ERP.ProductIndustry>
    {
        //private const string schema = "Actions";
        public ProductIndustryMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.IndustryId);
            Map(x => x.Name)
                .Length(100)
                .Not.Nullable();
            Map(x => x.Note)
                .Length(100)
                .Nullable();

        }
    }

}