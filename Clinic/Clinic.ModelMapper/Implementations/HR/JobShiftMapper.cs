using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.HR
{
    public class JobShiftMapper : ClassMap<Clinic.Model.HR.JobShift>
    {
        //private const string schema = "Actions";
        public JobShiftMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.JobShiftId);
             Map(x => x.Name)
            .Length(100)
            .Nullable();
             Map(x => x.Duration)
                .Nullable();

           

        }
    }

}