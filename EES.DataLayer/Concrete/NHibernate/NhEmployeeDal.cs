

using Mitras.Core.DataAccess.NHibernate;
 
using EES.Entities.Concrete;
		 
using EES.DataLayer.Abstract;
		
namespace EES.DataLayer.Concrete.NHibernate
{
	public class NhEmployeeDal : NhEntityRepositoryBase<Employee>, IEmployeeDal
	{
		public NhEmployeeDal(NHibernateHelper nHibernateHelper):base(nHibernateHelper)
		{
		}
	}
}