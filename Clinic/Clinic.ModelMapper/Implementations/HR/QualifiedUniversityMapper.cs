using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.HR
{
    public class QualifiedUniversityeMapper : ClassMap<Clinic.Model.HR.QualifiedUniversity>
    {
        //private const string schema = "Actions";
        public QualifiedUniversityeMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.QualifiedUniversityId);
             Map(x => x.UniversityName)
            .Length(100)
            .Not.Nullable();
             Map(x => x.Degree)
            .Length(100)
            .Nullable();
             Map(x => x.Course)
            .Length(100)
            .Nullable();

        }
    }

}