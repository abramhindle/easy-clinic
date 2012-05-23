using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.Infrastructure;
using FluentNHibernate.Mapping;



namespace Clinic.Repository.NHibernate.Mapping.HR
{
    public class PartnerMapper : ClassMap<Clinic.Model.CRM.Partner>
    {
        //private const string schema = "Actions";
        public PartnerMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.PartnerId);
            Map(x => x.CustomerCode)
           .Length(100)
           .Nullable();
            Map(x => x.Name)
            .Length(100)
            .Nullable();
            Map(x => x.Description)
           .Length(100)
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
