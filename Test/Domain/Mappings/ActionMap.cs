using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using Domain.Entities;

namespace Domain.Mappings
{
    public class ActionMap : ComponentMap<Domain.Entities.Action>
    {
        public ActionMap()
        {
            Map(x => x.ActionName);
           
        }
    }
}
