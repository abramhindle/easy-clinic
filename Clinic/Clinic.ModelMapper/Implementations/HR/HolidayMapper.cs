using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.HR
{
    public class HolidayMapper : ClassMap<Clinic.Model.HR.Holiday>
    {
        //private const string schema = "Actions";
        public HolidayMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.HolidayId);
             Map(x => x.Note)
            .Length(100)
            .Nullable();
             Map(x => x.Date)
                .Nullable();
              Map(x => x.Recurring)
                .Nullable();
              Map(x => x.Length)
                .Nullable();

        }
    }

}
