using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.ERP.BusinessPartner
{
    public class PaymentOutPlanMapper : ClassMap<Clinic.Model.ERP.BusinessPartner.PaymentOutPlan>
    {
        //private const string schema = "Actions";
        public PaymentOutPlanMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.PaymentOutPlanId);

            Map(x => x.PaymentMethod)
                .Length(100)
                .Nullable();
            Map(x => x.DueDate)
                .Nullable();
             Map(x => x.ExpectedAmount)
                .Nullable();
             Map(x => x.Paid)
                .Nullable();
             Map(x => x.OutStanding)
                .Nullable();
             References(x => x.Currency)
                //.LazyLoad()
               .Nullable();
             References(x => x.History)
                //.LazyLoad()
               .Nullable();
        }
    }

}

