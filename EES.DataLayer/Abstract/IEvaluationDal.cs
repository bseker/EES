

using System.Collections.Generic;
using Mitras.Core.DataAccess;
 
using EES.Entities.Concrete;
		 
using EES.DataLayer.Abstract;
using EES.Entities.View;


namespace EES.DataLayer.Abstract
{
	public interface IEvaluationDal : IEntityRepository<Evaluation>
	{
	    List<EvaluationView> GetEvaluationViewsByEvaluatedEmployeeId(int evaluatedEmployeeId);
	    List<EvaluationView> GetEvaluationsViewList();
	    List<EvaluationView> GetEvaluationViewsByEvaluatingEmployeeId(int evaluatingEmployeeId);
	}
}