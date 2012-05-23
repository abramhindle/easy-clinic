using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.EHR
{
    public class AssessmentAndPlanMapper : ClassMap<Clinic.Model.EHR.AssessmentAndPlan>
    {
        //private const string schema = "Actions";
        public AssessmentAndPlanMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.AssessmentAndPlanId);          
            References(x => x.Assessment)
                //.LazyLoad()
               .Nullable();
            References(x => x.Plan)
                //.LazyLoad()
               .Nullable();
            References(x => x.CreatedBy)
                //.LazyLoad()
               .Nullable();
              Map(x => x.Name)
                .Length(100)
                .Nullable();
           

        }
    }

}


