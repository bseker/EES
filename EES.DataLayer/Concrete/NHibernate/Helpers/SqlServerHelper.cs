

using System.Reflection;
using Mitras.Core.DataAccess.NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace EES.DataLayer.Concrete.NHibernate.Helpers
{
    public class SqlServerHelper : NHibernateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            return Fluently.Configure().Database(MsSqlConfiguration.MsSql2012
                .ConnectionString(c => c.FromConnectionStringWithKey("connstr")).ShowSql())
                .Mappings(t => t.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                //.ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
                //.ExposeConfiguration(c => c.SetInterceptor(new SqlInterceptor()))
                .BuildSessionFactory();
        }
    }

    //public class SqlInterceptor : EmptyInterceptor
    //{
    //    public override SqlString OnPrepareStatement(SqlString sql)
    //    {
    //        Trace.WriteLine(sql.ToString());
    //        return base.OnPrepareStatement(sql);
    //    }
    //}
}
