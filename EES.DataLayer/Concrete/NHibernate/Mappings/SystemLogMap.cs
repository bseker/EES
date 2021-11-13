

using FluentNHibernate.Mapping;
 
using EES.Entities.Concrete;
        
namespace EES.DataLayer.Concrete.NHibernate.Mappings
{
    public class SystemLogMap : ClassMap<SystemLog>
    {
        public SystemLogMap()
        {
            Schema(@"dbo");

            Table(@"SystemLogs");

            LazyLoad();

         
            Id(x => x.LogId).Column("LogId");
        
         
            Map(x => x.UserId).Column("UserId");
         
            Map(x => x.DateTime).Column("DateTime");
         
            Map(x => x.LogTypeId).Column("LogTypeId");
                   
        }
    }
}
