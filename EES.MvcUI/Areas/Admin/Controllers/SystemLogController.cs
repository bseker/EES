

using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.MvcUI.Areas.Admin.Infrastructure;
         
using EES.MvcUI.Areas.Admin.Models.SystemLogModels;
        namespace EES.MvcUI.Areas.Admin.Controllers
{
    public class SystemLogController : AdminController
    {
        private readonly ISystemLogService _systemlogService;

        public SystemLogController(ISystemLogService systemlogService)
        {
            this._systemlogService = systemlogService;
        }

        //[ChildActionOnly]
        public ActionResult List()
        {
            var systemlog = _systemlogService.GetAll();

            return DataTableContent(systemlog);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new SystemLogSaveViewModel
            {
                SystemLog = new SystemLog()
            };

            return View("Save",model);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Create(SystemLog systemLog)
        {
            _systemlogService.Insert(systemLog);

            SuccessNotification("The item has been added");

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int logId)
        {
            var model = new SystemLogSaveViewModel
            {
                SystemLog = _systemlogService.GetById(logId)
            };

            return View("Save", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(SystemLog systemLog)
        {
            _systemlogService.Update(systemLog);

            SuccessNotification("The item has been updated");

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int logId)
        {
            _systemlogService.Delete(logId);

            SuccessNotification("The item has been deleted");

            return RedirectToAction("Index");
        }
    }
}
