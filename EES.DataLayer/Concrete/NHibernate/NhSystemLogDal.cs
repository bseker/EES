

using Mitras.Core.DataAccess.NHibernate;
 
using EES.Entities.Concrete;
		 
using EES.DataLayer.Abstract;
		
namespace EES.DataLayer.Concrete.NHibernate
{
	public class NhSystemLogDal : NhEntityRepositoryBase<SystemLog>, ISystemLogDal
	{
		public NhSystemLogDal(NHibernateHelper nHibernateHelper):base(nHibernateHelper)
		{
		}
	}
}