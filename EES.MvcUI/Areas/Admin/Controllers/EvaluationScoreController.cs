

using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.MvcUI.Areas.Admin.Infrastructure;
         
using EES.MvcUI.Areas.Admin.Models.EvaluationScoreModels;
        namespace EES.MvcUI.Areas.Admin.Controllers
{
    public class EvaluationScoreController : AdminController
    {
        private readonly IEvaluationScoreService _evaluationscoreService;

        public EvaluationScoreController(IEvaluationScoreService evaluationscoreService)
        {
            this._evaluationscoreService = evaluationscoreService;
        }

        //[ChildActionOnly]
        public ActionResult List()
        {
            var evaluationscore = _evaluationscoreService.GetAll();

            return DataTableContent(evaluationscore);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new EvaluationScoreSaveViewModel
            {
                EvaluationScore = new EvaluationScore()
            };

            return View("Save",model);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Create(EvaluationScore evaluationScore)
        {
            _evaluationscoreService.Insert(evaluationScore);

            SuccessNotification("The item has been added");

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int scoreId)
        {
            var model = new EvaluationScoreSaveViewModel
            {
                EvaluationScore = _evaluationscoreService.GetById(scoreId)
            };

            return View("Save", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(EvaluationScore evaluationScore)
        {
            _evaluationscoreService.Update(evaluationScore);

            SuccessNotification("The item has been updated");

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int scoreId)
        {
            _evaluationscoreService.Delete(scoreId);

            SuccessNotification("The item has been deleted");

            return RedirectToAction("Index");
        }
    }
}
