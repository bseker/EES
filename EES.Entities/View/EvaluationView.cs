using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EES.Entities.View
{
    public class EvaluationView
    {
        [Key]
        public virtual int EvaluationId { get; set; }
        public virtual decimal Score { get; set; }
        public virtual int? Year { get; set; }
        public virtual string CommentText { get; set; }
        public virtual int EvaluatedEmployeeId { get; set; }

        public virtual string EvaluatedEmployeeName { get; set; }

        public virtual string EvaluatedEmployeeSurname { get; set; }
        public virtual int EvaluatingEmployeeId { get; set; }

        public virtual string EvaluatingEmployeeName { get; set; }

        public virtual string EvaluatingEmployeeSurname { get; set; }
      
    }
}
