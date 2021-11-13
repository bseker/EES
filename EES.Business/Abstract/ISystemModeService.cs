

using System.Collections.Generic;
 
using EES.Entities.Concrete;
         

namespace EES.Business.Abstract
{
	public interface ISystemModeService
	{
		List<SystemMode> GetAll();

        SystemMode GetById(int modeId);

		SystemMode Insert(SystemMode systemMode);
     
		SystemMode Update(SystemMode systemMode);

        void Delete(int modeId);
	}
}