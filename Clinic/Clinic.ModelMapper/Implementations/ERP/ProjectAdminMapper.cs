using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace Clinic.Repository.NHibernate.Mapping.ERP
{
    public class ProjectAdminMapper : ClassMap<Clinic.Model.ERP.ProjectAdmin>
    {
        //private const string schema = "Actions";
        public ProjectAdminMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.ProjectAdminId);
             References(x => x.Employee)
                //.LazyLoad()
              .Nullable();

        }
    }

}