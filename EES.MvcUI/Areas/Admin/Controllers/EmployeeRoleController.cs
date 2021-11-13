

using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.MvcUI.Areas.Admin.Infrastructure;
         
using EES.MvcUI.Areas.Admin.Models.EmployeeRoleModels;
        namespace EES.MvcUI.Areas.Admin.Controllers
{
    public class EmployeeRoleController : AdminController
    {
        private readonly IEmployeeRoleService _employeeroleService;

        public EmployeeRoleController(IEmployeeRoleService employeeroleService)
        {
            this._employeeroleService = employeeroleService;
        }

        //[ChildActionOnly]
        public ActionResult List()
        {
            var employeerole = _employeeroleService.GetAll();

            return DataTableContent(employeerole);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new EmployeeRoleSaveViewModel
            {
                EmployeeRole = new EmployeeRole()
            };

            return View("Save",model);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeRole employeeRole)
        {
            _employeeroleService.Insert(employeeRole);

            SuccessNotification("The item has been added");

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int employeeRoleId)
        {
            var model = new EmployeeRoleSaveViewModel
            {
                EmployeeRole = _employeeroleService.GetById(employeeRoleId)
            };

            return View("Save", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeeRole employeeRole)
        {
            _employeeroleService.Update(employeeRole);

            SuccessNotification("The item has been updated");

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int employeeRoleId)
        {
            _employeeroleService.Delete(employeeRoleId);

            SuccessNotification("The item has been deleted");

            return RedirectToAction("Index");
        }
    }
}
