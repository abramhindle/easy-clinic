using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.HR
{
    public class MembershipTypeMapper : ClassMap<Clinic.Model.HR.MembershipType>
    {
        //private const string schema = "Actions";
        public MembershipTypeMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.MemberShipTypeId);
             Map(x => x.Name)
            .Length(100)
            .Not.Nullable();

        }
    }

}