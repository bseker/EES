

using System.Linq;
using System.Collections.Generic;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.DataLayer.Abstract;
         

namespace EES.Business.Concrete
{
    public class RoleManager : IRoleService
    {
        private readonly IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            this._roleDal = roleDal;;
        }

        public List<Role> GetAll()
        {
            return _roleDal.GetList();
        }

        public Role GetById(int roleId)
        {
            return _roleDal.Get(t=>t.RoleId==roleId);
        }

        public Role Insert(Role role)
        {
            return _roleDal.Add(role);
        } 

        public Role Update(Role role)
        {
            return _roleDal.Update(role);
        }

        public void Delete(int roleId)
        {
            var role = _roleDal.Get(t=>t.RoleId==roleId);

            _roleDal.Delete(role);
        }
    }
}