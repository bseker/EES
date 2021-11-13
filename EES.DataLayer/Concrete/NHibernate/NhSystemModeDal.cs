

using Mitras.Core.DataAccess.NHibernate;
 
using EES.Entities.Concrete;
         
using EES.DataLayer.Abstract;
        
namespace EES.DataLayer.Concrete.NHibernate
{
	public class NhSystemModeDal : NhEntityRepositoryBase<SystemMode>, ISystemModeDal
	{
	    public NhSystemModeDal(NHibernateHelper nHibernateHelper):base(nHibernateHelper)
		{
		}
	}
}