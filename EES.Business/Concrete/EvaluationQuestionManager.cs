

using System.Linq;
using System.Collections.Generic;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.DataLayer.Abstract;
using EES.Entities.View;


namespace EES.Business.Concrete
{
    public class EvaluationQuestionManager : IEvaluationQuestionService
    {
        private readonly IEvaluationQuestionDal _evaluationquestionDal;

        public EvaluationQuestionManager(IEvaluationQuestionDal evaluationquestionDal)
        {
            this._evaluationquestionDal = evaluationquestionDal;;
        }

        public List<EvaluationQuestion> GetAll()
        {
            return _evaluationquestionDal.GetList();
        }

        public EvaluationQuestion GetById(int questionId)
        {
            return _evaluationquestionDal.Get(t=>t.QuestionId==questionId);
        }

        public EvaluationQuestion Insert(EvaluationQuestion evaluationQuestion)
        {
            return _evaluationquestionDal.Add(evaluationQuestion);
        } 

        public EvaluationQuestion Update(EvaluationQuestion evaluationQuestion)
        {
            return _evaluationquestionDal.Update(evaluationQuestion);
        }

        public void Delete(int questionId)
        {
            var evaluationquestion = _evaluationquestionDal.Get(t=>t.QuestionId==questionId);

            _evaluationquestionDal.Delete(evaluationquestion);
        }

        public List<EvaluationQuestion> GetQuestionsByRole(int roleId)
        {
            return _evaluationquestionDal.GetQuestionsByRoleId(roleId);
        }

        public List<QuestionRoleView> GetQuestionRoleViews()
        {
            return _evaluationquestionDal.GetQuestionRoleViews();
        }
    }
}