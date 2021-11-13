

using FluentNHibernate.Mapping;
 
using EES.Entities.Concrete;
        
namespace EES.DataLayer.Concrete.NHibernate.Mappings
{
    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Schema(@"dbo");

            Table(@"Employee");

            LazyLoad();

         
            Id(x => x.EmployeeId).Column("EmployeeId");
        
         
            Map(x => x.Name).Column("Name");
         
            Map(x => x.Surname).Column("Surname");
         
            Map(x => x.DepartmentId).Column("DepartmentId");
         
            Map(x => x.SupervisorId).Column("SupervisorId");
                   
        }
    }
}
