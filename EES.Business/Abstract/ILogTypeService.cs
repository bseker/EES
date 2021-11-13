

using System.Collections.Generic;
 
using EES.Entities.Concrete;
         

namespace EES.Business.Abstract
{
	public interface ILogTypeService
	{
		List<LogType> GetAll();

        LogType GetById(int logTypeId);

		LogType Insert(LogType logType);
     
		LogType Update(LogType logType);

        void Delete(int logTypeId);
	}
}