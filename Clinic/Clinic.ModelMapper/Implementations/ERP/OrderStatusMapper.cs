﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.ERP
{
    public class OrderStatusMapper : ClassMap<Clinic.Model.ERP.OrderStatus>
    {
        //private const string schema = "Actions";
        public OrderStatusMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.OrderStatusId);
            References(x => x.LineItem)
                //.LazyLoad()
               .Nullable();
            References(x => x.TimeStamp)
                //.LazyLoad()
               .Nullable();
            Map(x => x.Status)
                .Length(100)
                .Nullable();

        }
    }

}