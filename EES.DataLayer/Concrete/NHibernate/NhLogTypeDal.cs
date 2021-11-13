

using Mitras.Core.DataAccess.NHibernate;
 
using EES.Entities.Concrete;
		 
using EES.DataLayer.Abstract;
		
namespace EES.DataLayer.Concrete.NHibernate
{
	public class NhLogTypeDal : NhEntityRepositoryBase<LogType>, ILogTypeDal
	{
		public NhLogTypeDal(NHibernateHelper nHibernateHelper):base(nHibernateHelper)
		{
		}
	}
}