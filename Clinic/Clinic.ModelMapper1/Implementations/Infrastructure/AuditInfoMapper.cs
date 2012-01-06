using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.Infrastructure
{
    public class AuditInfoMapper : ClassMap<Clinic.Model.Infrastructure.AuditInfo>
    {
        //private const string schema = "Actions";
        public AuditInfoMapper()
        {
            //  SchemaIs(schema);
            Map(x => x.CreateDate)
                .Nullable();
            References(x => x.CreateBy)
                //.LazyLoad()
               .Nullable();
            Map(x => x.LastModified)
             .Nullable();
            References(x => x.ModifiedBy)
                //.LazyLoad()
               .Nullable();


        }
    }

}