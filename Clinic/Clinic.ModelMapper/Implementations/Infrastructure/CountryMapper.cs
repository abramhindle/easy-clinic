using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.Infrastructure
{
    public class CountryMapper : ClassMap<Clinic.Model.Infrastructure.Country>
    {
        //private const string schema = "Actions";
        public CountryMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.CountryId);
            Map(x => x.Name)
                .Length(100)
                .Not.Nullable();
            Map(x => x.Iso3)
              .Length(100)
              .Nullable();
            Map(x => x.NumCode)             
             .Nullable();
          
        }
    }

}


