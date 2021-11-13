using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EES.Entities.View
{
    public class UserEmployeeView
    {
        [Key]
        public int UserId  { get; set; }
        public string email { get; set; }
        public string UserRole { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DepartmentId { get; set; }
        public int? SupervisorId { get; set; }
    }
}
