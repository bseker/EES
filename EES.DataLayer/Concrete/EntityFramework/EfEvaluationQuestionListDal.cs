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
    public class EfEvaluationQuestionListDal:EfEntityRepositoryBase<EvaluationQuestionList,EesContext>,IEvaluationQuestionListDal
    {
        public List<EvaluationQuestionsView> GetEvaluationQuestionsViewByEvaluationId(int evaluationId)
        {
            using (var context = new EesContext())
            {
                return context.EvaluationQuestionsViews.Where(x => x.EvaluationId == evaluationId).ToList();
            }
        }

        public List<EvaluationQuestionsView> GetEvaluationQuestionsView()
        {
            using (var context = new EesContext())
            {
                return context.EvaluationQuestionsViews.ToList();
            }
        }
    }
}
