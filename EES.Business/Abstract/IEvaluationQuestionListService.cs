

using System.Collections.Generic;
 
using EES.Entities.Concrete;
using EES.Entities.View;


namespace EES.Business.Abstract
{
	public interface IEvaluationQuestionListService
	{
		List<EvaluationQuestionList> GetAll();

		EvaluationQuestionList GetById(int ıd);

		EvaluationQuestionList Insert(EvaluationQuestionList evaluationQuestionList);
	 
		EvaluationQuestionList Update(EvaluationQuestionList evaluationQuestionList);

		void Delete(int ıd);
		List<EvaluationQuestionsView> GetEvaluationQuestionsViewByEvaluationId(int evaluationId);
	    List<EvaluationQuestionsView> GetEvaluationQuestionsView();
	}
}