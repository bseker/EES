

using System.Linq;
using System.Collections.Generic;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.DataLayer.Abstract;
         

namespace EES.Business.Concrete
{
    public class ProjectManager : IProjectService
    {
        private readonly IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            this._projectDal = projectDal;;
        }

        public List<Project> GetAll()
        {
            return _projectDal.GetList();
        }

        public Project GetById(int projectId)
        {
            return _projectDal.Get(t=>t.ProjectId==projectId);
        }

        public Project Insert(Project project)
        {
            return _projectDal.Add(project);
        } 

        public Project Update(Project project)
        {
            return _projectDal.Update(project);
        }

        public void Delete(int projectId)
        {
            var project = _projectDal.Get(t=>t.ProjectId==projectId);

            _projectDal.Delete(project);
        }
    }
}