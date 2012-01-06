using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.ERP;

using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.EHR
{
    public class PlanMapper : ClassMap<Clinic.Model.EHR.Plan>
    {
        //private const string schema = "Actions";
        public PlanMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.PlanId);          
            References(x => x.Services)
                //.LazyLoad()
               .Nullable();
            References(x => x.Products)
                //.LazyLoad()
               .Nullable();

        }
    }

}
