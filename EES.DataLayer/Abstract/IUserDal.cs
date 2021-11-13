

using Mitras.Core.DataAccess;
 
using EES.Entities.Concrete;
         
using EES.DataLayer.Abstract;
using EES.Entities.View;


namespace EES.DataLayer.Abstract
{
	public interface IUserDal : IEntityRepository<User>
	{
	    UserEmployeeView GetUserByEmail(string email);

	    User GetByEmail(string email);


	}
}