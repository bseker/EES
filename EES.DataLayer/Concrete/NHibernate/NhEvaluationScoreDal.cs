

using Mitras.Core.DataAccess.NHibernate;
 
using EES.Entities.Concrete;
         
using EES.DataLayer.Abstract;
        
namespace EES.DataLayer.Concrete.NHibernate
{
	public class NhEvaluationScoreDal : NhEntityRepositoryBase<EvaluationScore>, IEvaluationScoreDal
	{
	    public NhEvaluationScoreDal(NHibernateHelper nHibernateHelper):base(nHibernateHelper)
		{
		}
	}
}