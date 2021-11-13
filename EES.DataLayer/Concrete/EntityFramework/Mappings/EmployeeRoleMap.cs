using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EES.Entities.Concrete;

namespace EES.DataLayer.Concrete.EntityFramework.Mappings
{
    public class EmployeeRoleMap : EntityTypeConfiguration<EmployeeRole>
    {
        public EmployeeRoleMap()
        {
            HasKey(x => x.EmployeeRoleId);
        }
    }
}
