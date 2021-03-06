﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;



namespace Clinic.Repository.NHibernate.Mapping.Infrastructure
{
    public class DistrictMapper : ClassMap<Clinic.Model.Infrastructure.District>
    {
        //private const string schema = "Actions";
        public DistrictMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.DistrictId);
            Map(x => x.Name)
                .Length(100)
                .Not.Nullable();
            References(x => x.Province)
                //.LazyLoad()
               .Nullable();

        }
    }

}

