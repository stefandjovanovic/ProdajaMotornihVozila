using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProdajaMotornihVozila.Mapiranja;
using ProdajaMotornihVozila.Entiteti;

namespace ProdajaMotornihVozila
{
    static class DataLayer
    {
        private static ISessionFactory? factory;
        private static object lockObj;

        static DataLayer()
        {
            factory = null;
            lockObj = new object();
        }

        public static ISession? GetSession()
        {
            if (factory == null)
            {
                lock (lockObj)
                {
                    if (factory == null)
                    {
                        factory = CreateSessionFactory();
                    }
                }
            }

            return factory?.OpenSession();
        }

        private static ISessionFactory? CreateSessionFactory()
        {
            try
            {
                // ShowSql prikazuje SQL koji je generisan, ali u .NET Core aplikacijama se prikazuju u konzoli.
                // Ako se aplikacija pokrene sa dotnet bin\Debug\net8.0-windows\ProdavnicaIgracaka.dll, mogu da se vide
                //string cs = ConfigurationManager.ConnectionStrings["OracleCS"].ConnectionString;
                var cfg = OracleManagedDataClientConfiguration.Oracle10
                            .ShowSql()
                            .ConnectionString(c => c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S18697;Password=ynwa1892"));

                return Fluently.Configure()
                        .Database(cfg)
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ZaposleniMapiranja>())
                        //.ExposeConfiguration(BuildSchema)
                        .BuildSessionFactory();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        /*private static void BuildSchema(NHibernate.Cfg.Configuration cfg)
        {
            // Konfiguracija
        }*/
    }
}
