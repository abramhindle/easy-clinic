using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.Infrastructure;
using FluentNHibernate.Mapping;

namespace Clinic.ModelMapper.Implementations.HR.Attentdant
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
            .WithLengthOf(100)
            .Nullable();
            Map(x => x.Note)
           .WithLengthOf(100)
           .Nullable();
            References(x => x.Date)
               .Nullable();
            References(x => x.PerformedBy)
               .Nullable();
           

        }
    }

}