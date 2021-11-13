

using FluentNHibernate.Mapping;
 
using EES.Entities.Concrete;
        
namespace EES.DataLayer.Concrete.NHibernate.Mappings
{
    public class DepartmentMap : ClassMap<Department>
    {
        public DepartmentMap()
        {
            Schema(@"dbo");

            Table(@"Department");

            LazyLoad();

         
            Id(x => x.DepartmentId).Column("DepartmentId");
        
         
            Map(x => x.DepartmentName).Column("DepartmentName");
                   
        }
    }
}
