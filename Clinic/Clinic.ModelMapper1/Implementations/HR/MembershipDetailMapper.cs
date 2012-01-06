using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.HR
{
    public class MembershipDetailMapper : ClassMap<Clinic.Model.HR.MembershipDetail>
    {
        //private const string schema = "Actions";
        public MembershipDetailMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.MembershipDetailId);
             Map(x => x.Name)
            .WithLengthOf(100)
            .Not.Nullable();
             References(x => x.MembershipType)
                .Nullable();
           

        }
    }

}