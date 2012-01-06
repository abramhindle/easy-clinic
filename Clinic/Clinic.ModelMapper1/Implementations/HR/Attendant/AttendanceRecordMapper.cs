using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.HR.Attentdant
{
    public class AttendanceRecordMapper : ClassMap<Clinic.Model.HR.AttendanceRecord>
    {
        //private const string schema = "Actions";
        public AttendanceRecordMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.AttendanceRecordId);            
            References(x => x.Employee)
                //.LazyLoad()
               .Nullable();
            Map(x => x.PuchInTime)
                //.LazyLoad()
               .Nullable();
            Map(x => x.PuchInNote)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.PuchOutTime)
                //.LazyLoad()
              .Nullable();
            Map(x => x.PuchOutNote)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.Status)
               .WithLengthOf(100)
               .Nullable();
        }
    }

}
