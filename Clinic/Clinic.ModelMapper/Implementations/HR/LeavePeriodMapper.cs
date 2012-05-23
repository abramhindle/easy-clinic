using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.HR
{
    public class LeavePeriodMapper : ClassMap<Clinic.Model.HR.LeavePeriod>
    {
        //private const string schema = "Actions";
        public LeavePeriodMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.LeavePeriodId);
             Map(x => x.StartDate)
            .Nullable();
              Map(x => x.EndDate)
            .Nullable();

        }
    }

}
