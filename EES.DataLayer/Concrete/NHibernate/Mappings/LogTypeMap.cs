

using FluentNHibernate.Mapping;
 
using EES.Entities.Concrete;
        
namespace EES.DataLayer.Concrete.NHibernate.Mappings
{
    public class LogTypeMap : ClassMap<LogType>
    {
        public LogTypeMap()
        {
            Schema(@"dbo");

            Table(@"LogType");

            LazyLoad();

         
            Id(x => x.LogTypeId).Column("LogTypeId");
        
         
            Map(x => x.LogTypeName).Column("LogTypeName");
                   
        }
    }
}
