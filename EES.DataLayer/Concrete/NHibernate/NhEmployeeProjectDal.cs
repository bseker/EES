

using Mitras.Core.DataAccess.NHibernate;
 
using EES.Entities.Concrete;
		 
using EES.DataLayer.Abstract;
		
namespace EES.DataLayer.Concrete.NHibernate
{
	public class NhEmployeeProjectDal : NhEntityRepositoryBase<EmployeeProject>, IEmployeeProjectDal
	{
		public NhEmployeeProjectDal(NHibernateHelper nHibernateHelper):base(nHibernateHelper)
		{
		}
	}
}