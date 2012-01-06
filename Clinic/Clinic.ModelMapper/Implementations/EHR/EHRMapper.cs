using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.EHR
{
    public class EHRMapper : ClassMap<Clinic.Model.EHR.EHR>
    {
        //private const string schema = "Actions";
        public EHRMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.EHRId);          
            References(x => x.Partner)
                //.LazyLoad()
               .Nullable();
            References(x => x.MedicalHistories)
                //.LazyLoad()
               .Nullable();
            References(x => x.MedicalCounters)
                //.LazyLoad()
               .Nullable();

        }
    }

}
