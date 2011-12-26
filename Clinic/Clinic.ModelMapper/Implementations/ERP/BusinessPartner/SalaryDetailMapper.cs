using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.HR
{
    public class PaymentOutPlanMapper : ClassMap<Clinic.Model.HR.SalaryDetail>
    {
        //private const string schema = "Actions";
        public PaymentOutPlanMapper()
        {
            //  SchemaIs(schema);
           
             References(x => x.SalaryGrade)
                //.LazyLoad()
               .Nullable();
             References(x => x.Currency)
                //.LazyLoad()
               .Nullable();
            Map(x => x.MinValue)
                .Nullable();
             Map(x => x.MaxValue)
                .Nullable();
             Map(x => x.StepValue)
                .Nullable();
           
        }
    }

}
