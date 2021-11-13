using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EES.DataLayer.Abstract;
using EES.Entities.Concrete;
using EES.Entities.View;
using Mitras.Core.DataAccess.EntityFramework;

namespace EES.DataLayer.Concrete.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee,EesContext>,IEmployeeDal
    {
        public List<Employee> GetEmployeePeers(Employee employee)
        {
            using (var context = new EesContext())
            {
                return context.Employees.Where(x => x.EmployeeId != employee.EmployeeId && x.DepartmentId == employee.DepartmentId).ToList();
            }
        }

        public List<EmployeeRoleView> GetEmployeeRoles(Employee employee)
        {
            using (var context = new EesContext())
            {
                return context.EmployeeRoleViews.Where(x=>x.EmployeeId == employee.EmployeeId).ToList();
            }
        }

        public List<Employee> GetDepartmentManagers()
        {
            using (var context = new EesContext())
            {
                var managerList = context.EmployeeRoleViews.Where(x => x.RoleId == 1).ToList();
                List<Employee> managerEmployees = managerList.Select(employeeRoleView => context.Employees.SingleOrDefault(x => x.EmployeeId == employeeRoleView.EmployeeId)).ToList();

                return managerEmployees;
            }
        }

        public List<Employee> GetProjectMembers(int projectId)
        {
            using (var context = new EesContext())
            {

                var tempList = context.EmployeeProjectViews.Where(x => x.ProjectId == projectId).ToList();
                List<Employee> projectWorkers = tempList.Select(item => context.Employees.SingleOrDefault(x => x.EmployeeId == item.EmployeeId)).ToList();
                return projectWorkers;
                
            }
        }

        public EmployeeProjectView GetEmployeeProject(Employee employee)
        {
            using (var context = new EesContext())
            {
                return context.EmployeeProjectViews.SingleOrDefault(x => x.EmployeeId == employee.EmployeeId);
            }
        }

        public EmployeeView GetEmployeeViewById(int employeeId)
        {
            using (var context = new EesContext())
            {
                return context.EmployeeViews.SingleOrDefault(x => x.EmployeeId == employeeId);
            }
        }
    }
}
