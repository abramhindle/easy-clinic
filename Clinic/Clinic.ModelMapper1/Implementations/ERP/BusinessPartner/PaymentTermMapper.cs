using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;


using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.ERP.BusinessPartner
{
    public class PaymentTermMapper : ClassMap<Clinic.Model.ERP.PaymentTerm>
    {
        //private const string schema = "Actions";
        public PaymentTermMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.PaymentTermId);
             References(x => x.Partner)
                //.LazyLoad()
               .Nullable();
            Map(x => x.Name)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.Note)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.OffsetMonthDue)
                .Nullable();
             Map(x => x.OverDuePaymentDaysRule)
                .Nullable();
             Map(x => x.OverDuePaymentDayRule)
                .Nullable();

             References(x => x.FixedDueDate)
                //.LazyLoad()
               .Nullable();
        }
    }

}

