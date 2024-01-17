using Conservatorio.DS.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Conservatorio.DS
{
    public class Conexion
    {
        private static readonly ISessionFactory Factory;

        static Conexion()
        {
            Factory = CrearSessionFactory();
        }

        private static string ConnectionString
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings["Conservatorio.UI.Properties.Settings.ConservatorioConnString"].ConnectionString;
            }
        }

        private static void ActualizarSchema(Configuration cfg)
        {
            new SchemaUpdate(cfg).Execute(false, true);
        }

        private static void CrearSchema(Configuration cfg)
        {
            var schemaExport = new SchemaExport(cfg);
            schemaExport.Drop(false, true);
            schemaExport.Create(false, true);
        }

        private static ISessionFactory CrearSessionFactory()
        {
            return Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString(ConnectionString))
              .Mappings(m => m.FluentMappings.AddFromAssemblyOf<InstrumentoMap>())
              .ExposeConfiguration(ActualizarSchema)
              .BuildSessionFactory();
        }

        public static ISession EstablecerConexion()
        {
            return Factory.OpenSession();
        }
    }
}
