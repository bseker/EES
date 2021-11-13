

using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.MvcUI.Areas.Admin.Infrastructure;
         
using EES.MvcUI.Areas.Admin.Models.EmployeeModels;
        namespace EES.MvcUI.Areas.Admin.Controllers
{
    public class EmployeeController : AdminController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }

        //[ChildActionOnly]
        public ActionResult List()
        {
            var employee = _employeeService.GetAll();

            return DataTableContent(employee);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new EmployeeSaveViewModel
            {
                Employee = new Employee()
            };

            return View("Save",model);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            _employeeService.Insert(employee);

            SuccessNotification("The item has been added");

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int employeeId)
        {
            var model = new EmployeeSaveViewModel
            {
                Employee = _employeeService.GetById(employeeId)
            };

            return View("Save", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            _employeeService.Update(employee);

            SuccessNotification("The item has been updated");

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int employeeId)
        {
            _employeeService.Delete(employeeId);

            SuccessNotification("The item has been deleted");

            return RedirectToAction("Index");
        }
    }
}
