using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.HR.Attentdant
{
    public class TimeSheetMapper : ClassMap<Clinic.Model.HR.TimeSheet>
    {
        //private const string schema = "Actions";
        public TimeSheetMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.TimeSheetId);
            Map(x => x.Employee)
                .Nullable();
            Map(x => x.State)
            .WithLengthOf(100)
            .Nullable();
            References(x => x.StartDate)
               .Nullable();
            References(x => x.EndDate)
               .Nullable();
           

        }
    }

}
