using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;
using Clinic.Model.ERP;
using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.EHR
{
    public class MedicalCounterMapper : ClassMap<Clinic.Model.EHR.MedicalCounter>
    {
        //private const string schema = "Actions";
        public MedicalCounterMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.MedicalCounterId);    
      
            References(x => x.Partner)
                //.LazyLoad()
               .Nullable();
            Map(x => x.Date)
                .Nullable();
            References(x => x.HandleBy)
                //.LazyLoad()
               .Nullable();
            References(x => x.Referer)
                //.LazyLoad()
               .Nullable();
              
            References(x => x.ChiefComplain)
            //.LazyLoad()
            .Nullable();

            References(x => x.PhysicalExamization)
            //.LazyLoad()
            .Nullable();

            References(x => x.OrdersAndPrescriptions)
            //.LazyLoad()
            .Nullable();

            References(x => x.TestResult)
            //.LazyLoad()
            .Nullable();

            References(x => x.AssessmentAndPlan)
            //.LazyLoad()
            .Nullable();

             References(x => x.ProgressNote)
            //.LazyLoad()
            .Nullable();

        }
    }

}