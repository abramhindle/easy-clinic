using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.HR
{
    public class JobStatusMapper : ClassMap<Clinic.Model.HR.JobStatus>
    {
        //private const string schema = "Actions";
        public JobStatusMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.JobStatusId);
             Map(x => x.Name)
            .WithLengthOf(100)
            .Nullable();

        }
    }

}
