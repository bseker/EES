

using System.Linq;
using System.Collections.Generic;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.DataLayer.Abstract;
         

namespace EES.Business.Concrete
{
    public class SystemModeManager : ISystemModeService
    {
        private readonly ISystemModeDal _systemmodeDal;

        public SystemModeManager(ISystemModeDal systemmodeDal)
        {
            this._systemmodeDal = systemmodeDal;;
        }

        public List<SystemMode> GetAll()
        {
            return _systemmodeDal.GetList();
        }

        public SystemMode GetById(int modeId)
        {
            return _systemmodeDal.Get(t=>t.ModeId==modeId);
        }

        public SystemMode Insert(SystemMode systemMode)
        {
            return _systemmodeDal.Add(systemMode);
        } 

        public SystemMode Update(SystemMode systemMode)
        {
            return _systemmodeDal.Update(systemMode);
        }

        public void Delete(int modeId)
        {
            var systemmode = _systemmodeDal.Get(t=>t.ModeId==modeId);

            _systemmodeDal.Delete(systemmode);
        }
    }
}