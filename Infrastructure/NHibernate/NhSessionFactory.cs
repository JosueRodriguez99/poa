using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Infrastructure.Poa.Mappings;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Infrastructure.NHibernate
{
    public static class NhSessionFactory
    {
        public static ISessionFactory Create()
        {
            return Fluently.Configure()
              .Database(MsSqlConfiguration.MsSql2008.ConnectionString(@"Data Source = WIN-BMJRHVOG5KL\SQLEXPRESS; Initial Catalog = SIP; user id = sa; password = 12345"))
              //.Database(MsSqlConfiguration.MsSql2008.ConnectionString(@"Data Source = Rodolfo-PC\SQLEXPRESS; Initial Catalog = SIP; user id = sa; password = 12345"))
              .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ProgramaEstrategicoMap>())
              .ExposeConfiguration(cfg => { new SchemaExport(cfg).Create(false, true); })
              .BuildSessionFactory();
        }
    }
}