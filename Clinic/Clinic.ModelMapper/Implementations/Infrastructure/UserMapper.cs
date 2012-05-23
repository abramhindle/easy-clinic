using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using Clinic.Model.Infrastructure;


namespace Clinic.Repository.NHibernate.Mapping
{
    public class UserMapper : ClassMap<User>
    {
        private const string schema = "Users";
        public UserMapper()
        {
            Map(x => x.UserName)
               .Length(50)
               .Not.Nullable();
            Map(x => x.Password)
                .Length(50)
                .Not.Nullable();
            Map(x => x.PasswordHash)
                .Length(100)
                .Not.Nullable();
            Map(x => x.IsAdmin)
               .Nullable();
            Map(x => x.Name)
               .Length(100)
               .Not.Nullable();
            Map(x => x.Deleted)
              .Nullable();
            Map(x => x.Title)
            .Nullable();
            References(x => x.Department)
            .Nullable();
            Map(x => x.Mobile)
            .Length(100)
            .Nullable();
            Map(x => x.Email)
          .Length(100)
          .Nullable();
            Map(x => x.Address)
          .Length(100)
          .Nullable();
            References(x => x.City)
          .Nullable();
            References(x => x.Country)
          .Nullable();
            Map(x => x.ZipCode)
       .Length(100)
        .Nullable();

            Map(x => x.DateEnter)
                .Nullable();
            Map(x => x.DateModify)
                  .Nullable();
            References(x => x.ModifiedBy)
                  .Nullable();
            References(x => x.CreatedBy)
                           .Nullable();
            References(x => x.Employee)
                  .Nullable();
            References(x => x.UserGroup)
                  .Nullable();


        }
    }


}
