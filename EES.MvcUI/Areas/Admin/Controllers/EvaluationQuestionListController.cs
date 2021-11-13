

using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.MvcUI.Areas.Admin.Infrastructure;
         
using EES.MvcUI.Areas.Admin.Models.EvaluationQuestionListModels;
        namespace EES.MvcUI.Areas.Admin.Controllers
{
    public class EvaluationQuestionListController : AdminController
    {
        private readonly IEvaluationQuestionListService _evaluationquestionlistService;

        public EvaluationQuestionListController(IEvaluationQuestionListService evaluationquestionlistService)
        {
            this._evaluationquestionlistService = evaluationquestionlistService;
        }

        //[ChildActionOnly]
        public ActionResult List()
        {
            var evaluationquestionlist = _evaluationquestionlistService.GetAll();

            return DataTableContent(evaluationquestionlist);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new EvaluationQuestionListSaveViewModel
            {
                EvaluationQuestionList = new EvaluationQuestionList()
            };

            return View("Save",model);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Create(EvaluationQuestionList evaluationQuestionList)
        {
            _evaluationquestionlistService.Insert(evaluationQuestionList);

            SuccessNotification("The item has been added");

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int ıd)
        {
            var model = new EvaluationQuestionListSaveViewModel
            {
                EvaluationQuestionList = _evaluationquestionlistService.GetById(ıd)
            };

            return View("Save", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(EvaluationQuestionList evaluationQuestionList)
        {
            _evaluationquestionlistService.Update(evaluationQuestionList);

            SuccessNotification("The item has been updated");

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int ıd)
        {
            _evaluationquestionlistService.Delete(ıd);

            SuccessNotification("The item has been deleted");

            return RedirectToAction("Index");
        }
    }
}
