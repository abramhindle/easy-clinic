using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.HR
{
    public class JobEECMapper : ClassMap<Clinic.Model.HR.JobEEC>
    {
        //private const string schema = "Actions";
        public JobEECMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.JobECCId);
             Map(x => x.Name)
            .Length(100)
            .Not.Nullable();
          
           

        }
    }

}