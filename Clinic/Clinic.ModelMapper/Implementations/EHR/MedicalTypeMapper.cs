using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.EHR
{
    public class MedicalTypeMapper : ClassMap<Clinic.Model.EHR.MedicalType>
    {
        //private const string schema = "Actions";
        public MedicalTypeMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.MedicalTypeId);          
              Map(x => x.Name)
                .WithLengthOf(100)
                .Not.Nullable();
           

        }
    }

}
