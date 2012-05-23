using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;
using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.CRM
{
    public class DiscountPlanMapper : ClassMap<Clinic.Model.ERP.Discount>
    {
        //private const string schema = "Actions";
        public DiscountPlanMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.DiscountId);   
              Map(x => x.Name)
                .Length(100)
                .Nullable();
              Map(x => x.Value)
                .Nullable();
              Map(x => x.IsActive)
                .Nullable();
            References(x => x.Products)
                //.LazyLoad()
               .Nullable();
            References(x => x.Partners)
                //.LazyLoad()
               .Nullable();
            References(x => x.Categories)
                //.LazyLoad()
               .Nullable();
            
           

        }
    }

}
