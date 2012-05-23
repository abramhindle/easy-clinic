using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;



namespace Clinic.Repository.NHibernate.Mapping.Infrastructure
{
    public class LocationMapper : ClassMap<Clinic.Model.Infrastructure.Location>
    {
        //private const string schema = "Actions";
        public LocationMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.LocationId);
            Map(x => x.Name)
                .Length(100)
                .Not.Nullable();
            References(x => x.Country)
                .Nullable();
            Map(x => x.State)
                .Length(100)
                .Nullable();
            Map(x => x.City)
                .Length(100)
                .Nullable();
            Map(x => x.Phone)
                .Length(100)
                .Nullable();
            Map(x => x.Fax)
                .Length(100)
                .Nullable();
            Map(x => x.Email)
                .Length(100)
                .Nullable();
            Map(x => x.Note)
              .Length(100)
              .Nullable();
            
        }
    }

}

