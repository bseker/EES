

using FluentNHibernate.Mapping;
 
using EES.Entities.Concrete;
        
namespace EES.DataLayer.Concrete.NHibernate.Mappings
{
    public class ProjectMap : ClassMap<Project>
    {
        public ProjectMap()
        {
            Schema(@"dbo");

            Table(@"Project");

            LazyLoad();

         
            Id(x => x.ProjectId).Column("ProjectId");
        
         
            Map(x => x.ProjectName).Column("ProjectName");
                   
        }
    }
}
