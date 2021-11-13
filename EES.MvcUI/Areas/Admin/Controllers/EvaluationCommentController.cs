

using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.MvcUI.Areas.Admin.Infrastructure;
         
using EES.MvcUI.Areas.Admin.Models.EvaluationCommentModels;
        namespace EES.MvcUI.Areas.Admin.Controllers
{
    public class EvaluationCommentController : AdminController
    {
        private readonly IEvaluationCommentService _evaluationcommentService;

        public EvaluationCommentController(IEvaluationCommentService evaluationcommentService)
        {
            this._evaluationcommentService = evaluationcommentService;
        }

        //[ChildActionOnly]
        public ActionResult List()
        {
            var evaluationcomment = _evaluationcommentService.GetAll();

            return DataTableContent(evaluationcomment);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new EvaluationCommentSaveViewModel
            {
                EvaluationComment = new EvaluationComment()
            };

            return View("Save",model);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Create(EvaluationComment evaluationComment)
        {
            _evaluationcommentService.Insert(evaluationComment);

            SuccessNotification("The item has been added");

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int commentId)
        {
            var model = new EvaluationCommentSaveViewModel
            {
                EvaluationComment = _evaluationcommentService.GetById(commentId)
            };

            return View("Save", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(EvaluationComment evaluationComment)
        {
            _evaluationcommentService.Update(evaluationComment);

            SuccessNotification("The item has been updated");

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int commentId)
        {
            _evaluationcommentService.Delete(commentId);

            SuccessNotification("The item has been deleted");

            return RedirectToAction("Index");
        }
    }
}
