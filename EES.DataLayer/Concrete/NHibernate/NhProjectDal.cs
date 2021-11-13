

using Mitras.Core.DataAccess.NHibernate;
 
using EES.Entities.Concrete;
		 
using EES.DataLayer.Abstract;
		
namespace EES.DataLayer.Concrete.NHibernate
{
	public class NhProjectDal : NhEntityRepositoryBase<Project>, IProjectDal
	{
		public NhProjectDal(NHibernateHelper nHibernateHelper):base(nHibernateHelper)
		{
		}
	}
}