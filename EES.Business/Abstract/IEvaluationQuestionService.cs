

using System.Collections.Generic;
 
using EES.Entities.Concrete;
using EES.Entities.View;


namespace EES.Business.Abstract
{
	public interface IEvaluationQuestionService
	{
		List<EvaluationQuestion> GetAll();

		EvaluationQuestion GetById(int questionId);

		EvaluationQuestion Insert(EvaluationQuestion evaluationQuestion);
	 
		EvaluationQuestion Update(EvaluationQuestion evaluationQuestion);

		void Delete(int questionId);
		List<EvaluationQuestion> GetQuestionsByRole(int roleId);
		List<QuestionRoleView> GetQuestionRoleViews();
	}
}