

using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.MvcUI.Areas.Admin.Infrastructure;
         
using EES.MvcUI.Areas.Admin.Models.LogTypeModels;
        namespace EES.MvcUI.Areas.Admin.Controllers
{
    public class LogTypeController : AdminController
    {
        private readonly ILogTypeService _logtypeService;

        public LogTypeController(ILogTypeService logtypeService)
        {
            this._logtypeService = logtypeService;
        }

        //[ChildActionOnly]
        public ActionResult List()
        {
            var logtype = _logtypeService.GetAll();

            return DataTableContent(logtype);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new LogTypeSaveViewModel
            {
                LogType = new LogType()
            };

            return View("Save",model);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Create(LogType logType)
        {
            _logtypeService.Insert(logType);

            SuccessNotification("The item has been added");

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int logTypeId)
        {
            var model = new LogTypeSaveViewModel
            {
                LogType = _logtypeService.GetById(logTypeId)
            };

            return View("Save", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(LogType logType)
        {
            _logtypeService.Update(logType);

            SuccessNotification("The item has been updated");

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int logTypeId)
        {
            _logtypeService.Delete(logTypeId);

            SuccessNotification("The item has been deleted");

            return RedirectToAction("Index");
        }
    }
}
