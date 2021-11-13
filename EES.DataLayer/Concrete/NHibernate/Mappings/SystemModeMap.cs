

using FluentNHibernate.Mapping;
 
using EES.Entities.Concrete;
        
namespace EES.DataLayer.Concrete.NHibernate.Mappings
{
    public class SystemModeMap : ClassMap<SystemMode>
    {
        public SystemModeMap()
        {
            Schema(@"dbo");

            Table(@"SystemMode");

            LazyLoad();

         
            Id(x => x.ModeId).Column("ModeId");
        
         
            Map(x => x.ModeName).Column("ModeName");
         
            Map(x => x.IsCurrentSystemMode).Column("IsCurrentSystemMode");
                   
        }
    }
}
