using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.Infrastructure;
using FluentNHibernate.Mapping;



namespace Clinic.ModelMapper.Implementations.HR
{
    public class PartnerMapper : ClassMap<Clinic.Model.CRM.Partner>
    {
        //private const string schema = "Actions";
        public PartnerMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.PartnerId);
            Map(x => x.CustomerCode)
           .WithLengthOf(100)
           .Nullable();
            Map(x => x.Name)
            .WithLengthOf(100)
            .Nullable();
            Map(x => x.Description)
           .WithLengthOf(100)
           .Nullable();
             References(x => x.Location)
                .Nullable();
             References(x => x.PartnerType)
               .Nullable();
             Map(x => x.Deleted)
               .Nullable();
           

        }
    }

}
