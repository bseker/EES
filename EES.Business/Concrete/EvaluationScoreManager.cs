

using System.Linq;
using System.Collections.Generic;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.DataLayer.Abstract;
         

namespace EES.Business.Concrete
{
    public class EvaluationScoreManager : IEvaluationScoreService
    {
        private readonly IEvaluationScoreDal _evaluationscoreDal;

        public EvaluationScoreManager(IEvaluationScoreDal evaluationscoreDal)
        {
            this._evaluationscoreDal = evaluationscoreDal;;
        }

        public List<EvaluationScore> GetAll()
        {
            return _evaluationscoreDal.GetList();
        }

        public EvaluationScore GetById(int scoreId)
        {
            return _evaluationscoreDal.Get(t=>t.ScoreId==scoreId);
        }

        public EvaluationScore Insert(EvaluationScore evaluationScore)
        {
            return _evaluationscoreDal.Add(evaluationScore);
        } 

        public EvaluationScore Update(EvaluationScore evaluationScore)
        {
            return _evaluationscoreDal.Update(evaluationScore);
        }

        public void Delete(int scoreId)
        {
            var evaluationscore = _evaluationscoreDal.Get(t=>t.ScoreId==scoreId);

            _evaluationscoreDal.Delete(evaluationscore);
        }
    }
}