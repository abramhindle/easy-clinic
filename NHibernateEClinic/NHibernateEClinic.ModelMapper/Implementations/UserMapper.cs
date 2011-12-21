using System;
using System.Collections.Generic;
using System.Text;

using FluentNHibernate.Mapping;
using NHibernateEClinic.Model;

namespace NHibernateEClinic.ModelMapper.Implementations
{
    public class UserMapper : ClassMap<User>
    {
        private const string schema = "Users";
        public UserMapper()
        {
            SchemaIs(schema);
            Id(x => x.UserId);
            Map(x => x.FirstName)
                .WithLengthOf(50)
                .Nullable();
            Map(x => x.LastName)
                .WithLengthOf(50)
                .Nullable();
            Map(x => x.UserName)
                .WithLengthOf(50)
                .Not.Nullable();
            Map(x => x.Password)
                .WithLengthOf(50)
                .Not.Nullable();
            Map(x => x.Address)
                .WithLengthOf(200)
                .Nullable();           
            Map(x => x.Phone)
                .WithLengthOf(50)
                .Nullable();
            Map(x => x.Email)
                .WithLengthOf(100)
                .Nullable();
          
            Map(x => x.CreatedDate);
            Map(x => x.IsLogin);
            //Map(x => x.RoleList);
                
          
        }
    }

}
