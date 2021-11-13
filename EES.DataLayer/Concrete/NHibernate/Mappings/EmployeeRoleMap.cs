

using FluentNHibernate.Mapping;
 
using EES.Entities.Concrete;
        
namespace EES.DataLayer.Concrete.NHibernate.Mappings
{
    public class EmployeeRoleMap : ClassMap<EmployeeRole>
    {
        public EmployeeRoleMap()
        {
            Schema(@"dbo");

            Table(@"EmployeeRole");

            LazyLoad();

         
            Id(x => x.EmployeeRoleId).Column("EmployeeRoleId");
        
         
            Map(x => x.RoleId).Column("RoleId");
         
            Map(x => x.EmployeeId).Column("EmployeeId");
                   
        }
    }
}
