

using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.MvcUI.Areas.Admin.Infrastructure;
         
using EES.MvcUI.Areas.Admin.Models.DepartmentModels;
        namespace EES.MvcUI.Areas.Admin.Controllers
{
    public class DepartmentController : AdminController
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            this._departmentService = departmentService;
        }

        //[ChildActionOnly]
        public ActionResult List()
        {
            var department = _departmentService.GetAll();

            return DataTableContent(department);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new DepartmentSaveViewModel
            {
                Department = new Department()
            };

            return View("Save",model);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Create(Department department)
        {
            _departmentService.Insert(department);

            SuccessNotification("The item has been added");

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int departmentId)
        {
            var model = new DepartmentSaveViewModel
            {
                Department = _departmentService.GetById(departmentId)
            };

            return View("Save", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(Department department)
        {
            _departmentService.Update(department);

            SuccessNotification("The item has been updated");

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int departmentId)
        {
            _departmentService.Delete(departmentId);

            SuccessNotification("The item has been deleted");

            return RedirectToAction("Index");
        }
    }
}
