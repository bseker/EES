

using System.Collections.Generic;
 
using EES.Entities.Concrete;
         

namespace EES.Business.Abstract
{
	public interface IDepartmentService
	{
		List<Department> GetAll();

        Department GetById(int departmentId);

		Department Insert(Department department);
     
		Department Update(Department department);

        void Delete(int departmentId);
	}
}