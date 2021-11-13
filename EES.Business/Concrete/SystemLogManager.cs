

using System.Linq;
using System.Collections.Generic;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.DataLayer.Abstract;
         

namespace EES.Business.Concrete
{
    public class SystemLogManager : ISystemLogService
    {
        private readonly ISystemLogDal _systemlogDal;

        public SystemLogManager(ISystemLogDal systemlogDal)
        {
            this._systemlogDal = systemlogDal;;
        }

        public List<SystemLog> GetAll()
        {
            return _systemlogDal.GetList();
        }

        public SystemLog GetById(int logId)
        {
            return _systemlogDal.Get(t=>t.LogId==logId);
        }

        public SystemLog Insert(SystemLog systemLog)
        {
            return _systemlogDal.Add(systemLog);
        } 

        public SystemLog Update(SystemLog systemLog)
        {
            return _systemlogDal.Update(systemLog);
        }

        public void Delete(int logId)
        {
            var systemlog = _systemlogDal.Get(t=>t.LogId==logId);

            _systemlogDal.Delete(systemlog);
        }
    }
}