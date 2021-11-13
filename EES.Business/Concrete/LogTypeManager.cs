

using System.Linq;
using System.Collections.Generic;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.DataLayer.Abstract;
         

namespace EES.Business.Concrete
{
    public class LogTypeManager : ILogTypeService
    {
        private readonly ILogTypeDal _logtypeDal;

        public LogTypeManager(ILogTypeDal logtypeDal)
        {
            this._logtypeDal = logtypeDal;;
        }

        public List<LogType> GetAll()
        {
            return _logtypeDal.GetList();
        }

        public LogType GetById(int logTypeId)
        {
            return _logtypeDal.Get(t=>t.LogTypeId==logTypeId);
        }

        public LogType Insert(LogType logType)
        {
            return _logtypeDal.Add(logType);
        } 

        public LogType Update(LogType logType)
        {
            return _logtypeDal.Update(logType);
        }

        public void Delete(int logTypeId)
        {
            var logtype = _logtypeDal.Get(t=>t.LogTypeId==logTypeId);

            _logtypeDal.Delete(logtype);
        }
    }
}