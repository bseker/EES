using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EES.Business.Abstract;
using EES.Entities.View;
using EES.MvcUI.Areas.Admin.Infrastructure;
using EES.MvcUI.Areas.Admin.Models.EvaluationReportModels;

namespace EES.MvcUI.Areas.Admin.Controllers
{
    public class EvaluationReportController : AdminController
    {
        private readonly IUserService _userService;
        private readonly IEmployeeService _employeeService;
        private readonly IEvaluationService _evaluationService;
        private readonly IEvaluationQuestionListService _evaluationQuestionListService;

        public EvaluationReportController(IUserService userService, IEmployeeService employeeService, IEvaluationService evaluationService, IEvaluationQuestionListService evaluationQuestionListService)
        {
            _userService = userService;
            _employeeService = employeeService;
            _evaluationService = evaluationService;
            _evaluationQuestionListService = evaluationQuestionListService;
        }

        // GET: Admin/EvaluationReport
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEvaluations()
        {
            
            List<EvaluationView> evaluationViewList = _evaluationService.GetEvaluationViews();

            return DataTableContent(evaluationViewList);
        }

        public ActionResult ViewEvaluationDetail(int evaluationId)
        {

            var viewModel = new EvaluationDetailViewModel();

            var questionLists =_evaluationQuestionListService.GetEvaluationQuestionsView();
            viewModel.QuestionList = questionLists;

            return View(viewModel);
        }
    }
}