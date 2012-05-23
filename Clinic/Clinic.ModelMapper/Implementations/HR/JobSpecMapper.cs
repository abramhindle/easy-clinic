using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.HR
{
    public class JobSpecMapper : ClassMap<Clinic.Model.HR.JobSpec>
    {
        //private const string schema = "Actions";
        public JobSpecMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.JobSpecId);
             Map(x => x.Name)
            .Length(100)
            .Nullable();
            Map(x => x.Description)
            .Nullable();
             Map(x => x.Duties)
            .Nullable();
           

        }
    }

}