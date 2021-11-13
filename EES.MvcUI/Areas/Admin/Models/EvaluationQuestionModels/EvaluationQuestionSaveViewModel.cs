

 
using System.Collections.Generic;
using EES.Entities.Concrete;
        
namespace EES.MvcUI.Areas.Admin.Models.EvaluationQuestionModels
{
    public class EvaluationQuestionSaveViewModel
    {
        public virtual EvaluationQuestion EvaluationQuestion { get; set; }
        public virtual List<Role> Roles { get; set; }

    }
}

