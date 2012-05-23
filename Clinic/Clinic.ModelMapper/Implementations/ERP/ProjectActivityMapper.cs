using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;

namespace Clinic.Repository.NHibernate.Mapping.ERP
{
    public class ProjectActivityMapper : ClassMap<Clinic.Model.ERP.ProjectActivity>
    {
        //private const string schema = "Actions";
        public ProjectActivityMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.ProjectActivityId);
            References(x => x.Project)
                //.LazyLoad()
              .Nullable();
            Map(x => x.Name)
                .Length(100)
                .Nullable();
            Map(x => x.Description)
                .Length(100)
                .Nullable();
        }
    }

}