using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.ERP;
using Clinic.Model.CRM;
using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.HR.Attentdant
{
    public class TimeSheetItemMapper : ClassMap<Clinic.Model.HR.TimeSheetItem>
    {
        //private const string schema = "Actions";
        public TimeSheetItemMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.TimeSheetItemId);
            Map(x => x.TimeSheet)
                .Nullable();
            Map(x => x.Date)
                .Nullable();
            Map(x => x.Duration)
               .Nullable();
            Map(x => x.Note)
            .WithLengthOf(100)
            .Nullable();
            References(x => x.ProjectActivity)
               .Nullable();
            References(x => x.Project)
               .Nullable();
            References(x => x.Employee)
               .Nullable();

        }
    }

}


