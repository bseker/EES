

using System.Linq;
using System.Collections.Generic;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.DataLayer.Abstract;
using EES.Entities.View;


namespace EES.Business.Concrete
{
    public class EvaluationManager : IEvaluationService
    {
        private readonly IEvaluationDal _evaluationDal;

        public EvaluationManager(IEvaluationDal evaluationDal)
        {
            this._evaluationDal = evaluationDal;;
        }

        public List<Evaluation> GetAll()
        {
            return _evaluationDal.GetList();
        }

        public Evaluation GetById(int evaluationId)
        {
            return _evaluationDal.Get(t=>t.EvaluationId==evaluationId);
        }

        public Evaluation Insert(Evaluation evaluation)
        {
            return _evaluationDal.Add(evaluation);
        } 

        public Evaluation Update(Evaluation evaluation)
        {
            return _evaluationDal.Update(evaluation);
        }

        public void Delete(int evaluationId)
        {
            var evaluation = _evaluationDal.Get(t=>t.EvaluationId==evaluationId);

            _evaluationDal.Delete(evaluation);
        }

        public List<EvaluationView> GetEvaluationViewByEvaluatedEmployeeId(int evaluatedEmployeeId)
        {
            return _evaluationDal.GetEvaluationViewsByEvaluatedEmployeeId(evaluatedEmployeeId);
        }

        public List<EvaluationView> GetEvaluationViews()
        {
            return _evaluationDal.GetEvaluationsViewList();
        }

        public List<EvaluationView> GetEvaluationViewByEvaluatingEmployeeId(int evaluatingEmployeeId)
        {
            return _evaluationDal.GetEvaluationViewsByEvaluatingEmployeeId(evaluatingEmployeeId);
        }
    }
}