

using Mitras.Core.DataAccess.NHibernate;
 
using EES.Entities.Concrete;
		 
using EES.DataLayer.Abstract;
		
namespace EES.DataLayer.Concrete.NHibernate
{
	public class NhEvaluationDal : NhEntityRepositoryBase<Evaluation>, IEvaluationDal
	{
		public NhEvaluationDal(NHibernateHelper nHibernateHelper):base(nHibernateHelper)
		{
		}
	}
}