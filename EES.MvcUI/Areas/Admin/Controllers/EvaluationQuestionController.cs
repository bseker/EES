

using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
using EES.Entities.View;
using EES.MvcUI.Areas.Admin.Infrastructure;
         
using EES.MvcUI.Areas.Admin.Models.EvaluationQuestionModels;
        namespace EES.MvcUI.Areas.Admin.Controllers
{
    public class EvaluationQuestionController : AdminController
    {
        private readonly IEvaluationQuestionService _evaluationquestionService;
        private readonly IRoleService _roleService;

        public EvaluationQuestionController(IEvaluationQuestionService evaluationquestionService, IRoleService roleService)
        {
            this._evaluationquestionService = evaluationquestionService;
            this._roleService = roleService;
        }

        //[ChildActionOnly]
        public ActionResult List()
        {
            List<QuestionRoleView> evaluationquestion = _evaluationquestionService.GetQuestionRoleViews();

            return DataTableContent(evaluationquestion);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {

            var model = new EvaluationQuestionSaveViewModel
            {
                Roles = _roleService.GetAll(),
                EvaluationQuestion = new EvaluationQuestion()
            };

            return View("Save",model);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Create(EvaluationQuestionSaveViewModel evaluationQuestionViewModel)
        {
            _evaluationquestionService.Insert(evaluationQuestionViewModel.EvaluationQuestion);

            SuccessNotification("The item has been added");

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int questionId)
        {
            var model = new EvaluationQuestionSaveViewModel
            {
                EvaluationQuestion = _evaluationquestionService.GetById(questionId),
                Roles = _roleService.GetAll()
            };

            return View("Save", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(EvaluationQuestion evaluationQuestion)
        {
            _evaluationquestionService.Update(evaluationQuestion);

            SuccessNotification("The item has been updated");

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int questionId)
        {
            _evaluationquestionService.Delete(questionId);

            SuccessNotification("The item has been deleted");

            return RedirectToAction("Index");
        }
    }
}
