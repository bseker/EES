

using System.Collections.Generic;
 
using EES.Entities.Concrete;
         

namespace EES.Business.Abstract
{
	public interface IRoleService
	{
		List<Role> GetAll();

        Role GetById(int roleId);

		Role Insert(Role role);
     
		Role Update(Role role);

        void Delete(int roleId);
	}
}