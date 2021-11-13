using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EES.Entities.View
{
    public class EvaluationQuestionsView
    {
        [Key]
        public virtual int EvaluationId { get; set; }

        public virtual int? EmployeeId { get; set; }

        public virtual string Name { get; set; }

        public virtual string Surname { get; set; }
        public virtual decimal Score { get; set; }
        public virtual int? Year { get; set; }

        public virtual int QuestionId { get; set; }

        public virtual string QuestionText { get; set; }

        public virtual int? QuestionWeight { get; set; }

        public virtual int? GivenRating { get; set; }

        public virtual int CommentId { get; set; }
        public virtual string CommentText { get; set; }

        public virtual string CommentType { get; set; }

   
    }
}
