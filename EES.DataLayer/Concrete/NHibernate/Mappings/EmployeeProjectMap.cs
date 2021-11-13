

using FluentNHibernate.Mapping;
 
using EES.Entities.Concrete;
        
namespace EES.DataLayer.Concrete.NHibernate.Mappings
{
    public class EmployeeProjectMap : ClassMap<EmployeeProject>
    {
        public EmployeeProjectMap()
        {
            Schema(@"dbo");

            Table(@"EmployeeProject");

            LazyLoad();

         
            Id(x => x.EmployeeProjectId).Column("EmployeeProjectId");
        
         
            Map(x => x.EmployeeRoleId).Column("EmployeeRoleId");
         
            Map(x => x.ProjectId).Column("ProjectId");
                   
        }
    }
}
