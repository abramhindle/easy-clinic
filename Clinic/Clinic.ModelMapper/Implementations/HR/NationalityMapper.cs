using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.HR
{
    public class NationalityMapper : ClassMap<Clinic.Model.HR.Nationality>
    {
        //private const string schema = "Actions";
        public NationalityMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.NationalityId);
            Map(x => x.Name)
           .WithLengthOf(100)
           .Not.Nullable();

        }
    }
}