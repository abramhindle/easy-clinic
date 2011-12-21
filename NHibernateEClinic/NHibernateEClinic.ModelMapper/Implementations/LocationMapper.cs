using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;



namespace NHibernateEClinic.ModelMapper.Implementations
{
    public class LocationMapper : ClassMap<Clinic.Model.Infrastructure.Location>
    {
        //private const string schema = "Actions";
        public LocationMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.LocationId);
            Map(x => x.Name)
                .WithLengthOf(100)
                .Not.Nullable();
            Map(x => x.Country)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.State)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.City)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.Phone)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.Fax)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.Email)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.Note)
              .WithLengthOf(100)
              .Nullable();
            
        }
    }

}

