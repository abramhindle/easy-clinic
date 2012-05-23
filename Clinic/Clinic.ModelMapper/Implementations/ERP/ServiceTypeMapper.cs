using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace Clinic.Repository.NHibernate.Mapping.ERP
{
    public class ServiceTypeMapper : ClassMap<Clinic.Model.ERP.ServiceType>
    {
        //private const string schema = "Actions";
        public ServiceTypeMapper()
        {
          
        }
    }

}
