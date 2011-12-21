using System;
using System.Collections.Generic;
using System.Text;

using FluentNHibernate.Mapping;
using NHibernateEClinic.Model;

namespace NHibernateEClinic.ModelMapper.Implementations
{
    public class RoleMapper : ClassMap<Role>
    {
        private const string schema = "Roles";
        public RoleMapper()
        {
            SchemaIs(schema);
            Id(x => x.RoleId);
            Map(x => x.RoleName)
                .WithLengthOf(100)
                .Not.Nullable();
         //   Map(x => x.ActionList);
                
        }
    }

}
