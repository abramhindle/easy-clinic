using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.CRM
{
    public class PartnerTypeMapper : ClassMap<Clinic.Model.CRM.PartnerType>
    {
        //private const string schema = "Actions";
        public PartnerTypeMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.PartnerTypeId);

            Map(x => x.Name)
                .WithLengthOf(100)
                .Nullable();

        }
    }

}
