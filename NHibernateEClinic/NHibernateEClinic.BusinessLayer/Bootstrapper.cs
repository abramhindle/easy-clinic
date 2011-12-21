using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap;
using NHibernateEClinic.BusinessLayer.Repositories;
using NHibernateEClinic.BusinessLayer.Repositories.Implementations;
namespace NHibernateEClinic.BusinessLayer
{
    public static class Bootstrapper
    {
        public static void Setup()
        {
            IContainer container = new Container();
            StructureMapConfiguration
                .ForRequestedType<IActionRepository>()
                        .TheDefaultIsConcreteType<ActionRepository>()
                        .CacheBy(StructureMap.Attributes.InstanceScope.Singleton);
        }
    }
}
