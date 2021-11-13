

using System.Collections.Generic;
 
using EES.Entities.Concrete;
         

namespace EES.Business.Abstract
{
	public interface IEmployeeProjectService
	{
		List<EmployeeProject> GetAll();

        EmployeeProject GetById(int employeeProjectId);

		EmployeeProject Insert(EmployeeProject employeeProject);
     
		EmployeeProject Update(EmployeeProject employeeProject);

        void Delete(int employeeProjectId);
	}
}