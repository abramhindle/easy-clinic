using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.Infrastructure
{
    public class UserGroupMapper : ClassMap<Clinic.Model.Infrastructure.UserGroup>
    {
        //private const string schema = "Actions";
        public UserGroupMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.UserGroupId);
            Map(x => x.Name)
                .Length(100)
                .Not.Nullable();
           

        }
    }

}



