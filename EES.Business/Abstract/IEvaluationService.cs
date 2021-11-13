

using System.Collections.Generic;
 
using EES.Entities.Concrete;
using EES.Entities.View;


namespace EES.Business.Abstract
{
	public interface IEvaluationService
	{
		List<Evaluation> GetAll();

		Evaluation GetById(int evaluationId);

		Evaluation Insert(Evaluation evaluation);
	 
		Evaluation Update(Evaluation evaluation);

		void Delete(int evaluationId);
		List<EvaluationView> GetEvaluationViewByEvaluatedEmployeeId(int evaluatedEmployeeId);
	    List<EvaluationView> GetEvaluationViews();
	    List<EvaluationView> GetEvaluationViewByEvaluatingEmployeeId(int evaluatingEmployeeId);
	}
}