

using System.Collections.Generic;
 
using EES.Entities.Concrete;
         

namespace EES.Business.Abstract
{
	public interface IProjectService
	{
		List<Project> GetAll();

        Project GetById(int projectId);

		Project Insert(Project project);
     
		Project Update(Project project);

        void Delete(int projectId);
	}
}