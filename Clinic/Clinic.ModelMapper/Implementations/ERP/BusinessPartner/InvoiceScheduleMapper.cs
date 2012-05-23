using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.ERP.BusinessPartner
{
    public class InvoiceScheduleMapper : ClassMap<Clinic.Model.ERP.BusinessPartner.InvoiceSchedule>
    {
        //private const string schema = "Actions";
        public InvoiceScheduleMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.InvoiceScheduleId);          
           
            Map(x => x.Name)
                .Length(100)
                .Nullable();
            Map(x => x.Note)
                .Length(100)
                .Nullable();

        }
    }

}
