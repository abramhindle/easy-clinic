using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.HR
{
    public class SkillMapper : ClassMap<Clinic.Model.HR.Skill>
    {
        //private const string schema = "Actions";
        public SkillMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.SkillId);
             Map(x => x.Description)
            .Length(100)
            .Nullable();

        }
    }
}