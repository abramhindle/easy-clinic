using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.ERP
{
    public class ProductMapper : ClassMap<Clinic.Model.ERP.Inventory.Product>
    {
        //private const string schema = "Actions";
        public ProductMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.ProductId);
             Map(x => x.Code)
                .Length(100)
                .Not.Nullable();
             Map(x => x.Name)
                .Length(100)
                .Nullable();
             Map(x => x.Description)
                .Length(100)
                .Nullable();
             Map(x => x.Note)
                .Length(100)
                .Nullable();
             Map(x => x.BarCode)
                .Length(100)
                .Nullable();
            Map(x => x.Picture)
                .Length(100)
                .Nullable();
            Map(x => x.IsSuppliment)
                .Nullable();
            Map(x => x.IsPurchase)
                .Nullable();
            References(x => x.Protection)
                //.LazyLoad()
               .Nullable();
            Map(x => x.Position)
                .Length(100)
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