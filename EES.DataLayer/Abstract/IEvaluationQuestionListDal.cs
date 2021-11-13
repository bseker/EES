

using System.Collections.Generic;
using Mitras.Core.DataAccess;
 
using EES.Entities.Concrete;
		 
using EES.DataLayer.Abstract;
using EES.Entities.View;


namespace EES.DataLayer.Abstract
{
	public interface IEvaluationQuestionListDal : IEntityRepository<EvaluationQuestionList>
	{
	    List<EvaluationQuestionsView> GetEvaluationQuestionsViewByEvaluationId(int evaluationId);
	    List<EvaluationQuestionsView> GetEvaluationQuestionsView();
	}
}