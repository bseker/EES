

using System.Linq;
using System.Collections.Generic;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.DataLayer.Abstract;
using EES.Entities.View;


namespace EES.Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            this._employeeDal = employeeDal;;
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetList();
        }

        public Employee GetById(int employeeId)
        {
            return _employeeDal.Get(t=>t.EmployeeId==employeeId);
        }

        public Employee Insert(Employee employee)
        {
            return _employeeDal.Add(employee);
        } 

        public Employee Update(Employee employee)
        {
            return _employeeDal.Update(employee);
        }

        public void Delete(int employeeId)
        {
            var employee = _employeeDal.Get(t=>t.EmployeeId==employeeId);

            _employeeDal.Delete(employee);
        }

        public List<Employee> GetEmployeeDepartmentWorkers(Employee employee)
        {
            var peerList = _employeeDal.GetEmployeePeers(employee);
            return peerList;
        }

        public List<EmployeeRoleView> GetEmployeeRoles(Employee employee)
        {
            return _employeeDal.GetEmployeeRoles(employee);
        }

        public List<Employee> GetDepartmentManagers()
        {
            return _employeeDal.GetDepartmentManagers();
        }

        public List<Employee> GetProjectMember(int projectId)
        {
            return _employeeDal.GetProjectMembers(projectId);
        }

        public EmployeeProjectView GetEmployeeProject(Employee employee)
        {
            return _employeeDal.GetEmployeeProject(employee);
        }

        public EmployeeView GetEmployeeViewById(int employeeId)
        {
            return _employeeDal.GetEmployeeViewById(employeeId);
        }
    }
}