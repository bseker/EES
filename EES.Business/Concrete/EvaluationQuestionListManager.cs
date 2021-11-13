

using System.Linq;
using System.Collections.Generic;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.DataLayer.Abstract;
using EES.Entities.View;


namespace EES.Business.Concrete
{
    public class EvaluationQuestionListManager : IEvaluationQuestionListService
    {
        private readonly IEvaluationQuestionListDal _evaluationquestionlistDal;

        public EvaluationQuestionListManager(IEvaluationQuestionListDal evaluationquestionlistDal)
        {
            this._evaluationquestionlistDal = evaluationquestionlistDal;;
        }

        public List<EvaluationQuestionList> GetAll()
        {
            return _evaluationquestionlistDal.GetList();
        }

        public EvaluationQuestionList GetById(int ıd)
        {
            return _evaluationquestionlistDal.Get(t=>t.Id==ıd);
        }

        public EvaluationQuestionList Insert(EvaluationQuestionList evaluationQuestionList)
        {
            return _evaluationquestionlistDal.Add(evaluationQuestionList);
        } 

        public EvaluationQuestionList Update(EvaluationQuestionList evaluationQuestionList)
        {
            return _evaluationquestionlistDal.Update(evaluationQuestionList);
        }

        public void Delete(int ıd)
        {
            var evaluationquestionlist = _evaluationquestionlistDal.Get(t=>t.Id==ıd);

            _evaluationquestionlistDal.Delete(evaluationquestionlist);
        }

        public List<EvaluationQuestionsView> GetEvaluationQuestionsViewByEvaluationId(int evaluationId)
        {
            return _evaluationquestionlistDal.GetEvaluationQuestionsViewByEvaluationId(evaluationId);
        }

        public List<EvaluationQuestionsView> GetEvaluationQuestionsView()
        {
            return _evaluationquestionlistDal.GetEvaluationQuestionsView();
        }
    }
}