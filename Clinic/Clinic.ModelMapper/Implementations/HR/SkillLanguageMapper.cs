using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.HR
{
    public class SkillLanguageMapper : ClassMap<Clinic.Model.HR.SkillLanguage>
    {
        //private const string schema = "Actions";
        public SkillLanguageMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.SkillLanguageId);
            Map(x => x.Name)
           .WithLengthOf(100)
           .Not.Nullable();

        }
    }
}
