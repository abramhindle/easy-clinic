using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;
using Clinic.Model.HR;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.EHR
{
    public class MedicalHistoryMapper : ClassMap<Clinic.Model.EHR.MedicalHistory>
    {
        //private const string schema = "Actions";
        public MedicalHistoryMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.MedicalHistoryId);                      
            References(x => x.Partner)
                //.LazyLoad()
                .Nullable();
            References(x => x.MedicalType)
                //.LazyLoad()
                .Nullable();
            Map(x => x.Date)
                .Nullable();
            Map(x => x.Detail)
                .Length(100)
                .Nullable();
            References(x => x.PerformedBy)
                //.LazyLoad()
                .Nullable();

        }
    }

}
