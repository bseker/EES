

using FluentNHibernate.Mapping;
 
using EES.Entities.Concrete;
        
namespace EES.DataLayer.Concrete.NHibernate.Mappings
{
    public class RoleMap : ClassMap<Role>
    {
        public RoleMap()
        {
            Schema(@"dbo");

            Table(@"Roles");

            LazyLoad();

         
            Id(x => x.RoleId).Column("RoleId");
        
         
            Map(x => x.RoleName).Column("RoleName");
                   
        }
    }
}
