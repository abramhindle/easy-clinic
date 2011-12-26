using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;
using FluentNHibernate.Mapping;

namespace Clinic.ModelMapper.Implementations.ERP
{
    public class ProjectMapper : ClassMap<Clinic.Model.ERP.Project>
    {
        //private const string schema = "Actions";
        public ProjectMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.ProjectId);
            References(x => x.Customer)
                //.LazyLoad()
              .Nullable();
            Map(x => x.Name)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.Description)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.Deleted)
                .Nullable();

        }
    }

}