

using System.Collections.Generic;
 
using EES.Entities.Concrete;
using EES.Entities.View;


namespace EES.Business.Abstract
{
	public interface IUserService
	{
		List<User> GetAll();

        User GetById(int userId);

		User Insert(User user);
     
		User Update(User user);

        void Delete(int userId);

	    UserEmployeeView GeEmployeeUserbyEmail(string email);

	    User GetbyEmail(string email);



	}
}