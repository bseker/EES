

using System.Collections.Generic;
using Mitras.Core.DataAccess;
 
using EES.Entities.Concrete;
		 
using EES.DataLayer.Abstract;
using EES.Entities.View;


namespace EES.DataLayer.Abstract
{
	public interface IEvaluationQuestionDal : IEntityRepository<EvaluationQuestion>
	{
	    List<EvaluationQuestion> GetQuestionsByRoleId(int roleId);
	    List<QuestionRoleView> GetQuestionRoleViews();
	}
}