using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.Infrastructure
{
    public class CurrencyMapper : ClassMap<Clinic.Model.Infrastructure.Currency>
    {
        //private const string schema = "Actions";
        public CurrencyMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.CurrencyId);  //1 2 3 4
            Map(x => x.Code) //VND USD
                .WithLengthOf(5)
                .Not.Nullable();
            Map(x => x.Name)
              .WithLengthOf(60)
              .Not.Nullable();
        }
    }

}


