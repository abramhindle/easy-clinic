﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace Clinic.Repository.NHibernate.Mapping.HR
{
    public class SalaryGradeMapper : ClassMap<Clinic.Model.HR.SalaryGrade>
    {
        //private const string schema = "Actions";
        public SalaryGradeMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.SalaryGradeId);

            Map(x => x.Name)
                .Length(100)
                .Nullable();

        }
    }

}