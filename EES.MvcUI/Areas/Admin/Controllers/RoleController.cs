

using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.MvcUI.Areas.Admin.Infrastructure;
         
using EES.MvcUI.Areas.Admin.Models.RoleModels;
        namespace EES.MvcUI.Areas.Admin.Controllers
{
    public class RoleController : AdminController
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            this._roleService = roleService;
        }

        //[ChildActionOnly]
        public ActionResult List()
        {
            var role = _roleService.GetAll();

            return DataTableContent(role);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new RoleSaveViewModel
            {
                Role = new Role()
            };

            return View("Save",model);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Create(Role role)
        {
            _roleService.Insert(role);

            SuccessNotification("The item has been added");

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int roleId)
        {
            var model = new RoleSaveViewModel
            {
                Role = _roleService.GetById(roleId)
            };

            return View("Save", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(Role role)
        {
            _roleService.Update(role);

            SuccessNotification("The item has been updated");

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int roleId)
        {
            _roleService.Delete(roleId);

            SuccessNotification("The item has been deleted");

            return RedirectToAction("Index");
        }
    }
}
