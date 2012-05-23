using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.Infrastructure;
using FluentNHibernate.Mapping;

namespace Clinic.Repository.NHibernate.Mapping.HR.Attentdant
{
    public class TimeSheetActionLogMapper : ClassMap<Clinic.Model.HR.TimeSheetActionLog>
    {
        //private const string schema = "Actions";
        public TimeSheetActionLogMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.TimeSheetActionLogId);
            Map(x => x.TimeSheet)
                .Nullable();
            Map(x => x.Action)
            .Length(100)
            .Nullable();
            Map(x => x.Note)
           .Length(100)
           .Nullable();
            Map(x => x.Date)
               .Nullable();
            References(x => x.PerformedBy)
               .Nullable();
           

        }
    }

}