

using Mitras.Core.DataAccess.NHibernate;
 
using EES.Entities.Concrete;
         
using EES.DataLayer.Abstract;
        
namespace EES.DataLayer.Concrete.NHibernate
{
	public class NhUserDal : NhEntityRepositoryBase<User>, IUserDal
	{
	    public NhUserDal(NHibernateHelper nHibernateHelper):base(nHibernateHelper)
		{
		}
	}
}