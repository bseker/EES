

using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.MvcUI.Areas.Admin.Infrastructure;
         
using EES.MvcUI.Areas.Admin.Models.EmployeeProjectModels;
        namespace EES.MvcUI.Areas.Admin.Controllers
{
    public class EmployeeProjectController : AdminController
    {
        private readonly IEmployeeProjectService _employeeprojectService;

        public EmployeeProjectController(IEmployeeProjectService employeeprojectService)
        {
            this._employeeprojectService = employeeprojectService;
        }

        //[ChildActionOnly]
        public ActionResult List()
        {
            var employeeproject = _employeeprojectService.GetAll();

            return DataTableContent(employeeproject);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new EmployeeProjectSaveViewModel
            {
                EmployeeProject = new EmployeeProject()
            };

            return View("Save",model);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeProject employeeProject)
        {
            _employeeprojectService.Insert(employeeProject);

            SuccessNotification("The item has been added");

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int employeeProjectId)
        {
            var model = new EmployeeProjectSaveViewModel
            {
                EmployeeProject = _employeeprojectService.GetById(employeeProjectId)
            };

            return View("Save", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeeProject employeeProject)
        {
            _employeeprojectService.Update(employeeProject);

            SuccessNotification("The item has been updated");

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int employeeProjectId)
        {
            _employeeprojectService.Delete(employeeProjectId);

            SuccessNotification("The item has been deleted");

            return RedirectToAction("Index");
        }
    }
}
