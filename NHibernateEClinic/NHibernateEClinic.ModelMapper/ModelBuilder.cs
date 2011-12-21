using FluentNHibernate;
using FluentNHibernate.Cfg;
using NHibernate;
using NHibernate.Cfg;

namespace NHibernateEClinic.ModelMapper
{
    //check : http://blog.vuscode.com/malovicn/archive/2008/08/31/fluent-nhibernate-nhibernate-without-configuration-files.aspx

    public static class ModelBuilder
    {
        private static Configuration cfg;
        private static ISessionFactory sessionFactory;

        static ModelBuilder()
        {
            buildModel();
        }
        public static ISessionFactory GetSessionFactory()
        {
            if (sessionFactory == null)
            {
                sessionFactory = cfg.BuildSessionFactory();
            }
            return sessionFactory;
        }

        private static void buildModel()
        {
            // initialize persistance configurer
            IPersistenceConfigurer persistenceConfigurer = getPersistenceConfigurer();
            // initialize nhibernate with persistance configurer properties
            cfg = persistenceConfigurer.ConfigureProperties(new Configuration());
            // add mappings definition to nhibernate configuration
            var persistenceModel = new PersistenceModel();
            persistenceModel.addMappingsFromAssembly(typeof(ModelBuilder).Assembly);
            persistenceModel.Conventions.GetPrimaryKeyName = x => x.Name;
            persistenceModel.Conventions.GetForeignKeyName = x => x.Name;
            persistenceModel.Configure(cfg);

            //Mix mode, this line allows us to append config settings to our configuration
            //instance from .config files (web.config,app.config)
            // or any other "traditional" (xml based) approach.
            //NOTE: If you are going to go with full Fluent configuration, you should remove the line below
            cfg.Configure();

        }

        private static IPersistenceConfigurer getPersistenceConfigurer()
        {
            //change here to target another database
            IPersistenceConfigurer persistenceConfigurer =
                MsSqlConfiguration
                    .MsSql2005
                    //.ConnectionString.Is("your connection string goes here")
                    .ShowSql();

            //for example this config target to a mysql database,
            //IPersistenceConfigurer persistenceConfigurer =
            //   MySQLConfiguration
            //       .Standard
            //       .ConnectionString.Is(connectionString)
            //       .ShowSql();

            return persistenceConfigurer;
        }



    }
}
