using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.ERP
{
    public class InventoryMapper : ClassMap<Clinic.Model.ERP.Inventory1>
    {
        //private const string schema = "Actions";
        public InventoryMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.InventoryId);
             References(x => x.Item)
                //.LazyLoad()
               .Nullable();
            Map(x => x.Quantity)
                .Nullable();
            Map(x => x.NomalizeStock)
                .Nullable();
             Map(x => x.BuyAvg)
                .Nullable();
             Map(x => x.SellAvg)
                .Nullable();

        }
    }

}
