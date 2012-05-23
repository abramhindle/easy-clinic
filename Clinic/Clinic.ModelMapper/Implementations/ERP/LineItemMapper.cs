using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.ERP
{
    public class LineItemMapper : ClassMap<Clinic.Model.ERP.LineItem>
    {
        //private const string schema = "Actions";
        public LineItemMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.LineItemId);
            References(x => x.OrderId)
                //.LazyLoad()
               .Nullable();
            References(x => x.Product)
                //.LazyLoad()
               .Nullable();
            Map(x => x.Quantity)
                .Nullable();
            Map(x => x.UnitPrice)
                .Nullable();
            References(x => x.Dicount)
                //.LazyLoad()
               .Nullable();

        }
    }

}
