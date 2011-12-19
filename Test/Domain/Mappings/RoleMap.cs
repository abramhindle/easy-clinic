using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using FluentNHibernate.Mapping;

namespace Domain.Mappings
{
    public class RoleMap : ComponentMap<Role>
    {
        public RoleMap()
        {
            Map(x => x.Id);
            Map(x => x.RoleName);
            HasMany(x => x.ActionList)
                .Cascade.All()
                .Inverse();
        }
    }
}
