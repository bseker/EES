

using System.Linq;
using System.Collections.Generic;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.DataLayer.Abstract;
         

namespace EES.Business.Concrete
{
    public class EmployeeProjectManager : IEmployeeProjectService
    {
        private readonly IEmployeeProjectDal _employeeprojectDal;

        public EmployeeProjectManager(IEmployeeProjectDal employeeprojectDal)
        {
            this._employeeprojectDal = employeeprojectDal;;
        }

        public List<EmployeeProject> GetAll()
        {
            return _employeeprojectDal.GetList();
        }

        public EmployeeProject GetById(int employeeProjectId)
        {
            return _employeeprojectDal.Get(t=>t.EmployeeProjectId==employeeProjectId);
        }

        public EmployeeProject Insert(EmployeeProject employeeProject)
        {
            return _employeeprojectDal.Add(employeeProject);
        } 

        public EmployeeProject Update(EmployeeProject employeeProject)
        {
            return _employeeprojectDal.Update(employeeProject);
        }

        public void Delete(int employeeProjectId)
        {
            var employeeproject = _employeeprojectDal.Get(t=>t.EmployeeProjectId==employeeProjectId);

            _employeeprojectDal.Delete(employeeproject);
        }
    }
}