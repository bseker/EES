

using System.Linq;
using System.Collections.Generic;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.DataLayer.Abstract;
         

namespace EES.Business.Concrete
{
    public class EmployeeRoleManager : IEmployeeRoleService
    {
        private readonly IEmployeeRoleDal _employeeroleDal;

        public EmployeeRoleManager(IEmployeeRoleDal employeeroleDal)
        {
            this._employeeroleDal = employeeroleDal;;
        }

        public List<EmployeeRole> GetAll()
        {
            return _employeeroleDal.GetList();
        }

        public EmployeeRole GetById(int employeeRoleId)
        {
            return _employeeroleDal.Get(t=>t.EmployeeRoleId==employeeRoleId);
        }

        public EmployeeRole Insert(EmployeeRole employeeRole)
        {
            return _employeeroleDal.Add(employeeRole);
        } 

        public EmployeeRole Update(EmployeeRole employeeRole)
        {
            return _employeeroleDal.Update(employeeRole);
        }

        public void Delete(int employeeRoleId)
        {
            var employeerole = _employeeroleDal.Get(t=>t.EmployeeRoleId==employeeRoleId);

            _employeeroleDal.Delete(employeerole);
        }
    }
}