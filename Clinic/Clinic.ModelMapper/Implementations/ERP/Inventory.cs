using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.ERP
{
    public class Inventory
    {
        public int InventoryId { set; get; }
        public Item Item { set; get; }
        public decimal Quantity { set; get; }
        public decimal NomalizeStock { set; get; }
        public decimal BuyAvg { set; get; }
        public decimal SellAvg { set; get; }
    }
}

using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.ERP
{
    public class InventoryMapper : ClassMap<Clinic.Model.ERP.Inventory>
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
