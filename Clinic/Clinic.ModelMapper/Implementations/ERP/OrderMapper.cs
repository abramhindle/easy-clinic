using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.HR;
using Clinic.Model.CRM;
using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.ERP
{
    public class OrderMapper : ClassMap<Clinic.Model.ERP.Order>
    {
        //private const string schema = "Actions";
        public OrderMapper()
        {
            //  SchemaIs(schema);
            Map(x => x.Date)
                .Nullable();
            References(x => x.Customer)
                //.LazyLoad()
               .Nullable();
            References(x => x.HandleBy)
                //.LazyLoad()
               .Nullable();
            References(x => x.LineItems)
                //.LazyLoad()
               .Nullable();
            References(x => x.Discount)
                //.LazyLoad()
               .Nullable();
            References(x => x.Payment)
                //.LazyLoad()
               .Nullable();
            Map(x => x.TotalPrice)
                .Nullable();
            References(x => x.Status)
                //.LazyLoad()
               .Nullable();

        }
    }

}
