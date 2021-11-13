

using System.Collections.Generic;
using Mitras.Core.DataAccess;
 
using EES.Entities.Concrete;
		 
using EES.DataLayer.Abstract;
using EES.Entities.View;


namespace EES.DataLayer.Abstract
{
	public interface IEmployeeDal : IEntityRepository<Employee>
	{
	    List<Employee> GetEmployeePeers(Employee employee);

	    List<EmployeeRoleView> GetEmployeeRoles(Employee employee);

	    List<Employee> GetDepartmentManagers();


	    List<Employee> GetProjectMembers(int projectId);
	    EmployeeProjectView GetEmployeeProject(Employee employee);
	    EmployeeView GetEmployeeViewById(int employeeId);
	}
}