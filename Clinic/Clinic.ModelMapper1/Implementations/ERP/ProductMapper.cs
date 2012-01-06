using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;

using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.ERP
{
    public class ProductMapper : ClassMap<Clinic.Model.ERP.Product>
    {
        //private const string schema = "Actions";
        public ProductMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.ProductId);
             Map(x => x.Code)
                .WithLengthOf(100)
                .Not.Nullable();
             Map(x => x.Name)
                .WithLengthOf(100)
                .Nullable();
             Map(x => x.Description)
                .WithLengthOf(100)
                .Nullable();
             Map(x => x.Note)
                .WithLengthOf(100)
                .Nullable();
             Map(x => x.BarCode)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.Picture)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.IsSuppliment)
                .Nullable();
            Map(x => x.IsPurchase)
                .Nullable();
            References(x => x.Protection)
                //.LazyLoad()
               .Nullable();
            Map(x => x.Position)
                .WithLengthOf(100)
                .Nullable();
            References(x => x.Unit)
                //.LazyLoad()
               .Nullable();
            Map(x => x.Tax)
                .Nullable();
           References(x => x.Dependencies)
                //.LazyLoad()
               .Nullable();

        }
    }

}