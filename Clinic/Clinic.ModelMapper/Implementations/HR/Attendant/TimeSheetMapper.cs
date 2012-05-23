using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.HR.Attentdant
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
            .Length(100)
            .Nullable();
            Map(x => x.StartDate)
               .Nullable();
            Map(x => x.EndDate)
               .Nullable();
           

        }
    }

}
