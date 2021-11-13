

using Mitras.Core.DataAccess.NHibernate;
 
using EES.Entities.Concrete;
         
using EES.DataLayer.Abstract;
        
namespace EES.DataLayer.Concrete.NHibernate
{
	public class NhRoleDal : NhEntityRepositoryBase<Role>, IRoleDal
	{
	    public NhRoleDal(NHibernateHelper nHibernateHelper):base(nHibernateHelper)
		{
		}
	}
}