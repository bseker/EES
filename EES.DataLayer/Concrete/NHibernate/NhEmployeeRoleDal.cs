

using Mitras.Core.DataAccess.NHibernate;
 
using EES.Entities.Concrete;
         
using EES.DataLayer.Abstract;
        
namespace EES.DataLayer.Concrete.NHibernate
{
	public class NhEmployeeRoleDal : NhEntityRepositoryBase<EmployeeRole>, IEmployeeRoleDal
	{
	    public NhEmployeeRoleDal(NHibernateHelper nHibernateHelper):base(nHibernateHelper)
		{
		}
	}
}