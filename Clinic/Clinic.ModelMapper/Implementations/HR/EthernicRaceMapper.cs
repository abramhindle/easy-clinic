using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace Clinic.Repository.NHibernate.Mapping.HR
{
    public class EthernicRaceMapper : ClassMap<Clinic.Model.HR.EthernicRace>
    {
        //private const string schema = "Actions";
        public EthernicRaceMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.EthernicRaceId);
            Map(x => x.Name)
                .Length(100)
                .Not.Nullable();
            
        }
    }

}
