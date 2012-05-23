using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.Infrastructure;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.HR
{
    public class CompStructureMapper : ClassMap<Clinic.Model.HR.CompStructure>
    {
        //private const string schema = "Actions";
        public CompStructureMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.Id);
             Map(x => x.Title)
            .Length(100)
            .Nullable();
             References(x => x.Location)
                .Nullable();
            References(x => x.Parrent)
               .Nullable();
            Map(x => x.DepartmentId)
              .Length(100)
               .Nullable();
           

        }
    }

}
