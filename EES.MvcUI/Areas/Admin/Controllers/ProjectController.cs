

using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.MvcUI.Areas.Admin.Infrastructure;
         
using EES.MvcUI.Areas.Admin.Models.ProjectModels;
        namespace EES.MvcUI.Areas.Admin.Controllers
{
    public class ProjectController : AdminController
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            this._projectService = projectService;
        }

        //[ChildActionOnly]
        public ActionResult List()
        {
            var project = _projectService.GetAll();

            return DataTableContent(project);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new ProjectSaveViewModel
            {
                Project = new Project()
            };

            return View("Save",model);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Create(Project project)
        {
            _projectService.Insert(project);

            SuccessNotification("The item has been added");

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int projectId)
        {
            var model = new ProjectSaveViewModel
            {
                Project = _projectService.GetById(projectId)
            };

            return View("Save", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(Project project)
        {
            _projectService.Update(project);

            SuccessNotification("The item has been updated");

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int projectId)
        {
            _projectService.Delete(projectId);

            SuccessNotification("The item has been deleted");

            return RedirectToAction("Index");
        }
    }
}
