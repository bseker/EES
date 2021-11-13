using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EES.DataLayer.Abstract;
using EES.Entities.Concrete;
using Mitras.Core.DataAccess.EntityFramework;

namespace EES.DataLayer.Concrete.EntityFramework
{
    public class EfEmployeeRoleDal : EfEntityRepositoryBase<EmployeeRole,EesContext>,IEmployeeRoleDal
    {
    }
}
