

using System.Collections.Generic;
 
using EES.Entities.Concrete;
using EES.Entities.View;


namespace EES.Business.Abstract
{
	public interface IEmployeeService
	{
		List<Employee> GetAll();

		Employee GetById(int employeeId);

		Employee Insert(Employee employee);
	 
		Employee Update(Employee employee);

		void Delete(int employeeId);

		List<Employee> GetEmployeeDepartmentWorkers(Employee employee);

		List<EmployeeRoleView> GetEmployeeRoles(Employee employee);

		List<Employee> GetDepartmentManagers();
		List<Employee> GetProjectMember(int projectId);
	    EmployeeProjectView GetEmployeeProject(Employee employee);
	    EmployeeView GetEmployeeViewById(int employeeId);
	}
}