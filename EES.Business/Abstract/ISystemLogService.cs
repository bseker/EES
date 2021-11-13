

using System.Collections.Generic;
 
using EES.Entities.Concrete;
         

namespace EES.Business.Abstract
{
	public interface ISystemLogService
	{
		List<SystemLog> GetAll();

        SystemLog GetById(int logId);

		SystemLog Insert(SystemLog systemLog);
     
		SystemLog Update(SystemLog systemLog);

        void Delete(int logId);
	}
}