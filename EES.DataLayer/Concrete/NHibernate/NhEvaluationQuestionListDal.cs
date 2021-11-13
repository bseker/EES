

using Mitras.Core.DataAccess.NHibernate;
 
using EES.Entities.Concrete;
		 
using EES.DataLayer.Abstract;
		
namespace EES.DataLayer.Concrete.NHibernate
{
	public class NhEvaluationQuestionListDal : NhEntityRepositoryBase<EvaluationQuestionList>, IEvaluationQuestionListDal
	{
		public NhEvaluationQuestionListDal(NHibernateHelper nHibernateHelper):base(nHibernateHelper)
		{
		}
	}
}