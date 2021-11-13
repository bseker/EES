using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EES.Entities.View
{
    public class QuestionRoleView
    {
        [Key]
        public virtual int QuestionId { get; set; }

        public virtual string QuestionText { get; set; }

        public virtual int? QuestionWeight { get; set; }

        public virtual int? RoleId { get; set; }
        public virtual string RoleName { get; set; }
    }
}
