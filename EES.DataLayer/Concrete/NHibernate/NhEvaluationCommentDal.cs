

using Mitras.Core.DataAccess.NHibernate;
 
using EES.Entities.Concrete;
		 
using EES.DataLayer.Abstract;
		
namespace EES.DataLayer.Concrete.NHibernate
{
	public class NhEvaluationCommentDal : NhEntityRepositoryBase<EvaluationComment>, IEvaluationCommentDal
	{
		public NhEvaluationCommentDal(NHibernateHelper nHibernateHelper):base(nHibernateHelper)
		{
		}
	}
}