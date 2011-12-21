using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;



namespace NHibernateEClinic.ModelMapper.Implementations
{
    public class JobTitleMapper : ClassMap<Clinic.Model.Infrastructure.JobTitle>
    {
        //private const string schema = "Actions";
        public JobTitleMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.JobTitleId);
            Map(x => x.Name)
                .WithLengthOf(100)
                .Not.Nullable();
            Map(x => x.Note)
                .WithLengthOf(100)
                .Not.Nullable();
            Map(x => x.IsActive)               
                .Not.Nullable();
            Map(x => x.SalaryGrade)              
              .Not.Nullable();
            Map(x => x.JobSpecId)                
                .Not.Nullable();
        }
    }

}
