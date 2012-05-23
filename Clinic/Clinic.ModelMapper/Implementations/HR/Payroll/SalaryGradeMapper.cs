using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.HR.Payroll
{
    public class SalaryGradeMapper : ClassMap<Clinic.Model.HR.SalaryGrade>
    {
        //private const string schema = "Actions";
        public SalaryGradeMapper()
        {
            //  SchemaIs(schema);
   
            Map(x => x.SalaryGradeId)
            .Length(100)
               .Nullable();
            Map(x => x.Name)
            .Length(100)
               .Nullable();
        }
    }

}
