using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.HR
{
    public class LeaveRequestMapper : ClassMap<Clinic.Model.HR.LeaveRequest>
    {
        //private const string schema = "Actions";
        public LeaveRequestMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.LeaveRequestId);
             References(x => x.LeaveType)
                .Nullable();
            References(x => x.LeavePeriod)
               .Nullable();
            References(x => x.Employee)
               .Nullable();
              Map(x => x.Name)
            .WithLengthOf(100)
            .Nullable();
             Map(x => x.Note)
            .WithLengthOf(100)
            .Nullable();
           Map(x => x.DateApply)
            .Nullable();

        }
    }

}