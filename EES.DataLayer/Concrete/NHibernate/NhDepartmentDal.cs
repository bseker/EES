

using Mitras.Core.DataAccess.NHibernate;
 
using EES.Entities.Concrete;
		 
using EES.DataLayer.Abstract;
		
namespace EES.DataLayer.Concrete.NHibernate
{
	public class NhDepartmentDal : NhEntityRepositoryBase<Department>, IDepartmentDal
	{
		public NhDepartmentDal(NHibernateHelper nHibernateHelper):base(nHibernateHelper)
		{
		}
	}
}