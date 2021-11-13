

using System.Collections.Generic;
 
using EES.Entities.Concrete;
         

namespace EES.Business.Abstract
{
	public interface IEvaluationCommentService
	{
		List<EvaluationComment> GetAll();

        EvaluationComment GetById(int commentId);

		EvaluationComment Insert(EvaluationComment evaluationComment);
     
		EvaluationComment Update(EvaluationComment evaluationComment);

        void Delete(int commentId);
	}
}