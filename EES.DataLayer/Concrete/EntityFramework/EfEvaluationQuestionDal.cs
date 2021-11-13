using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EES.DataLayer.Abstract;
using EES.Entities.Concrete;
using EES.Entities.View;
using Mitras.Core.DataAccess.EntityFramework;

namespace EES.DataLayer.Concrete.EntityFramework
{
    public class EfEvaluationQuestionDal:EfEntityRepositoryBase<EvaluationQuestion,EesContext>,IEvaluationQuestionDal
    {
        public List<EvaluationQuestion> GetQuestionsByRoleId(int roleId)
        {
            using (var context = new EesContext())
            {
                return context.EvaluationQuestions.Where(x => x.RoleId == roleId).ToList();
            }
        }

        public List<QuestionRoleView> GetQuestionRoleViews()
        {
            using (var context = new EesContext())
            {
                return context.QuestionRoleViews.ToList();
            }
        }
    }
}
