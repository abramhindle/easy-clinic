using System;
using System.Collections.Generic;
using System.Text;

using FluentNHibernate.Mapping;
using Clinic.Model.Infrastructure;


namespace Clinic.ModelMapper.Implementations.Infrastructure
{
    public class UserMapper : ClassMap<User>
    {
        private const string schema = "Users";
        public UserMapper()
        {
            SchemaIs(schema);
            Map(x => x.UserName)
               .WithLengthOf(50)
               .Not.Nullable();
            Map(x => x.Password)
                .WithLengthOf(50)
                .Not.Nullable();
            Map(x => x.PasswordHash)
                .WithLengthOf(100)
                .Not.Nullable();
            Map(x => x.IsAdmin)
               .Nullable();
            Map(x => x.Name)
               .WithLengthOf(100)
               .Not.Nullable();
            Map(x => x.Deleted)
              .Nullable();
            Map(x => x.Title)
            .Nullable();
            Map(x => x.Department)
            .Nullable();
            Map(x => x.Mobile)
            .WithLengthOf(100)
            .Nullable();
            Map(x => x.Email)
          .WithLengthOf(100)
          .Nullable();
            Map(x => x.Address)
          .WithLengthOf(100)
          .Nullable();
            Map(x => x.City)
          .WithLengthOf(100)
          .Nullable();
            Map(x => x.Country)
          .WithLengthOf(100)
          .Nullable();
            Map(x => x.ZipCode)
       .WithLengthOf(100)
       .Nullable();

            Map(x => x.DateEnter)
                .Nullable();
            Map(x => x.DateModify)
                  .Nullable();
            Map(x => x.ModifiedBy)
                  .Nullable();
            Map(x => x.CreatedBy)
                           .Nullable();
            Map(x => x.Employee)
                  .Nullable();
            Map(x => x.UserGroup)
                  .Nullable();


        }
    }


}
