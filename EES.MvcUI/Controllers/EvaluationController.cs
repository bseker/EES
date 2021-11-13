

using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.MvcUI.Infrastructure;
         
using EES.MvcUI.Models.EvaluationModels;

namespace EES.MvcUI.Controllers
{
    public class EvaluationController : BaseContoller
    {
        private readonly IEvaluationService _evaluationService;

        public EvaluationController(IEvaluationService evaluationService)
        {
            this._evaluationService = evaluationService;
        }

        //[ChildActionOnly]
        public ActionResult List()
        {
            var evaluation = _evaluationService.GetAll();

            return DataTableContent(evaluation);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new EvaluationSaveViewModel
            {
                Evaluation = new Evaluation()
            };

            return View("Save",model);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Create(Evaluation evaluation)
        {
            _evaluationService.Insert(evaluation);

            SuccessNotification("The item has been added");

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int evaluationId)
        {
            var model = new EvaluationSaveViewModel
            {
                Evaluation = _evaluationService.GetById(evaluationId)
            };

            return View("Save", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(Evaluation evaluation)
        {
            _evaluationService.Update(evaluation);

            SuccessNotification("The item has been updated");

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int evaluationId)
        {
            _evaluationService.Delete(evaluationId);

            SuccessNotification("The item has been deleted");

            return RedirectToAction("Index");
        }

     
    }
}
