

using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.MvcUI.Areas.Admin.Infrastructure;
         
using EES.MvcUI.Areas.Admin.Models.SystemModeModels;
        namespace EES.MvcUI.Areas.Admin.Controllers
{
    public class SystemModeController : AdminController
    {
        private readonly ISystemModeService _systemmodeService;

        public SystemModeController(ISystemModeService systemmodeService)
        {
            this._systemmodeService = systemmodeService;
        }

        //[ChildActionOnly]
        public ActionResult List()
        {
            var systemmode = _systemmodeService.GetAll();

            return DataTableContent(systemmode);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new SystemModeSaveViewModel
            {
                SystemMode = new SystemMode()
            };

            return View("Save",model);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Create(SystemMode systemMode)
        {
            _systemmodeService.Insert(systemMode);

            SuccessNotification("The item has been added");

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int modeId)
        {
            var model = new SystemModeSaveViewModel
            {
                SystemMode = _systemmodeService.GetById(modeId)
            };

            return View("Save", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(SystemMode systemMode)
        {
            _systemmodeService.Update(systemMode);

            SuccessNotification("The item has been updated");

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int modeId)
        {
            _systemmodeService.Delete(modeId);

            SuccessNotification("The item has been deleted");

            return RedirectToAction("Index");
        }
    }
}
