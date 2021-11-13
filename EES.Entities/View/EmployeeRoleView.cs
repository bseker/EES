using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EES.Entities.View
{
    public class EmployeeRoleView
    {
       
        [Key]
        public virtual int EmployeeId { get; set; }

        public virtual int? DepartmentId { get; set; }
        public virtual int? IdNumber { get; set; }

        public virtual string Name { get; set; }

        public virtual string Surname { get; set; }


        public virtual string RoleName { get; set; }
        public virtual int? RoleId { get; set; }

    }
}
