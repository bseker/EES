using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EES.Entities.Concrete;
using EES.MvcUI.Areas.Admin.Infrastructure;

namespace EES.MvcUI.Areas.Admin.Controllers
{
    public class SystemSettingsController : AdminController
    {
        // GET: Admin/SystemSettings
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SystemModeManagement()
        {
            return View();
        }

        public ActionResult EmailUtility()
        {
            return View();
        }

        public ActionResult ReminderList()
        {
            var reminderList = new List<Employee>()
            {
                new Employee() { EmployeeId = 2, Name = "Burak", Surname = "ŞEKER", DepartmentId = 1 },
                new Employee() { EmployeeId = 223, Name = "Aybüke", Surname = "Topçu", DepartmentId = 1 },
                new Employee() { EmployeeId = 34, Name = "Burçin", Surname = "Özcan", DepartmentId = 2 },
                new Employee() { EmployeeId = 41, Name = "İsmail", Surname = "El", DepartmentId = 3 },
            };

            return DataTableContent(reminderList);
        }

        public ActionResult ManageEvaluationQuestions()
        {
            var viewmodel = new EvaluationQuestion();
            return View(viewmodel);
        }

        public ActionResult ListEvaluationQuestions()
        {
            var questionList = new List<EvaluationQuestion>()
            {
                new EvaluationQuestion()
                {
                    QuestionText = "Some Question Written By HR for Peer Evaluation",
                    QuestionWeight = 10,
                    RoleId = 3
                },
                new EvaluationQuestion()
                {
                    QuestionText = "Some Question Written By HR for Managarial Evaluation",
                    QuestionWeight = 15,
                    RoleId = 2
                },
                new EvaluationQuestion()
                {
                    QuestionText = "Some Question Written By HR for Supervisor Evaluation",
                    QuestionWeight = 16,
                    RoleId = 1
                },
                new EvaluationQuestion()
                {
                    QuestionText = "Some Question Written By HR for Managarial Evaluation",
                    QuestionWeight = 29,
                    RoleId = 2
                },
                new EvaluationQuestion()
                {
                    QuestionText = "Some Question Written By HR for Peer Evaluation",
                    QuestionWeight = 20,
                    RoleId = 3
                },
            };

            return DataTableContent(questionList);
        }

    }
}