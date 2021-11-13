

using System.Collections.Generic;
 
using EES.Entities.Concrete;
         

namespace EES.Business.Abstract
{
	public interface IEvaluationScoreService
	{
		List<EvaluationScore> GetAll();

        EvaluationScore GetById(int scoreId);

		EvaluationScore Insert(EvaluationScore evaluationScore);
     
		EvaluationScore Update(EvaluationScore evaluationScore);

        void Delete(int scoreId);
	}
}