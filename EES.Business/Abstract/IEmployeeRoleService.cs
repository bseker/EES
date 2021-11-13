

using System.Collections.Generic;
 
using EES.Entities.Concrete;
         

namespace EES.Business.Abstract
{
	public interface IEmployeeRoleService
	{
		List<EmployeeRole> GetAll();

        EmployeeRole GetById(int employeeRoleId);

		EmployeeRole Insert(EmployeeRole employeeRole);
     
		EmployeeRole Update(EmployeeRole employeeRole);

        void Delete(int employeeRoleId);
	}
}