

using FluentNHibernate.Mapping;
 
using EES.Entities.Concrete;
        
namespace EES.DataLayer.Concrete.NHibernate.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Schema(@"dbo");

            Table(@"Users");

            LazyLoad();

         
            Id(x => x.UserId).Column("UserId");
        
         
            Map(x => x.email).Column("email");
         
            Map(x => x.UserRole).Column("UserRole");
         
            Map(x => x.EmployeeId).Column("EmployeeId");
                   
        }
    }
}
