using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using FluentNHibernate.Mapping;

namespace Domain.Mappings
{
    public class UserMap : ComponentMap<User>
    {
        public UserMap()
        {
            Map(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.UserName);
            Map(x => x.Password);
            Map(x => x.Email);
            Map(x => x.Phone);
            Map(x => x.Address);
            Map(x => x.CreatedDate);
            Map(x => x.IsLogin);
            HasMany(x => x.RoleList)
                .Cascade.All()
                .Inverse();
        }
    }
}
