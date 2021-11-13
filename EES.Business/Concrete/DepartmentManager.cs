

using System.Linq;
using System.Collections.Generic;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.DataLayer.Abstract;
         

namespace EES.Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private readonly IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            this._departmentDal = departmentDal;;
        }

        public List<Department> GetAll()
        {
            return _departmentDal.GetList();
        }

        public Department GetById(int departmentId)
        {
            return _departmentDal.Get(t=>t.DepartmentId==departmentId);
        }

        public Department Insert(Department department)
        {
            return _departmentDal.Add(department);
        } 

        public Department Update(Department department)
        {
            return _departmentDal.Update(department);
        }

        public void Delete(int departmentId)
        {
            var department = _departmentDal.Get(t=>t.DepartmentId==departmentId);

            _departmentDal.Delete(department);
        }
    }
}