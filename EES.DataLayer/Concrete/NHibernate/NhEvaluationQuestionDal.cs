

using Mitras.Core.DataAccess.NHibernate;
 
using EES.Entities.Concrete;
         
using EES.DataLayer.Abstract;
        
namespace EES.DataLayer.Concrete.NHibernate
{
	public class NhEvaluationQuestionDal : NhEntityRepositoryBase<EvaluationQuestion>, IEvaluationQuestionDal
	{
	    public NhEvaluationQuestionDal(NHibernateHelper nHibernateHelper):base(nHibernateHelper)
		{
		}
	}
}