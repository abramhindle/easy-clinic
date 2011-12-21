using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.Infrastructure
{
    public class CompStructureMapper : ClassMap<Clinic.Model.HR.CompStructure>
    {
        //private const string schema = "Actions";
        public CompStructureMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.Id);  
            Map(x => x.Title) 
                .WithLengthOf(100)
                .Not.Nullable();         
            References(x => x.Location)
                //.LazyLoad()
               .Nullable();
            References(x => x.Parrent)
                //.LazyLoad()
               .Nullable();
            Map(x => x.DepartmentId) 
              .WithLengthOf(50)
              .Not.Nullable();

        }
    }

}



