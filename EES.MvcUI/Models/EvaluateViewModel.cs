using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EES.Entities.Concrete;
using EES.Entities.View;

namespace EES.MvcUI.Models
{
    public class EvaluateViewModel
    {

        public EmployeeView EvaluatedEmployee { get; set; }

        public EmployeeView EvaluatingEmployee { get; set; }

        public Evaluation Evaluation { get; set; }

        public EvaluationComment Comment { get; set; }

        public IList<EvaluationQuestion> Questions { get; set; }

        public EmployeeProjectView EvaluatedEmployeeProjects { get; set; }


    }
}