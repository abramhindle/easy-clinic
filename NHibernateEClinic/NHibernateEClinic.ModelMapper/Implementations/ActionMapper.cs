using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;


namespace NHibernateEClinic.ModelMapper.Implementations
{
    public class ActionMapper : ClassMap<NHibernateEClinic.Model.Action>
    {
        //private const string schema = "Actions";
        public ActionMapper()
        {
          //  SchemaIs(schema);
            Id(x => x.ActionID);
            Map(x => x.ActionName)
                .WithLengthOf(60)
                .Not.Nullable();
           
        }
    }

}

