using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.ERP
{
    public class ItemMapper : ClassMap<Clinic.Model.ERP.Item>
    {
        //private const string schema = "Actions";
        public ItemMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.ItemId);
            References(x => x.Product)
                //.LazyLoad()
               .Nullable();
            References(x => x.Supplier)
                //.LazyLoad()
               .Nullable();
            Map(x => x.Name)
                .Length(100)
                .Nullable();
            Map(x => x.Status)
                .Length(100)
                .Nullable();
             Map(x => x.Image)
                .Length(100)
                .Nullable();
            Map(x => x.UnitCost)
                .Nullable();
             Map(x => x.ListedPrice)
                .Nullable();
             Map(x => x.RetailPrice)
                .Nullable();

             References(x => x.Discount)
                //.LazyLoad()
               .Nullable();
            References(x => x.ManufactureDate)
                //.LazyLoad()
               .Nullable();
            References(x => x.ExpirationDate)
                //.LazyLoad()
               .Nullable();
        }
    }

}