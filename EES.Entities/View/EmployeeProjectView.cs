using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EES.Entities.View
{
    public class EmployeeProjectView
    {
        [Key]
        public virtual int EmployeeId { get; set; }

        public virtual string Name { get; set; }

        public virtual string Surname { get; set; }

        public virtual string ProjectName { get; set; }
        public virtual int ProjectId { get; set; }
        public virtual int EmployeeRoleId { get; set; }

        public virtual int? RoleId { get; set; }
        public virtual string RoleName { get; set; }
      
    }
}
