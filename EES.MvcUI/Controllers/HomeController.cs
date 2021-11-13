using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EES.Business.Abstract;
using EES.Entities.Concrete;
using EES.Entities.View;
using EES.MvcUI.Areas.Admin.Infrastructure;
using EES.MvcUI.Models;
using EES.MvcUI.Infrastructure;
using Mitras.Core.CrossCuttingConcerns.Security;

namespace EES.MvcUI.Controllers
{
    public class HomeController : AdminController
    {
        private readonly IEmployeeService _employeeService;
        private readonly IUserService _userService;
        private readonly IEvaluationQuestionService _evaluationQuestionService;
        private readonly IEvaluationCommentService _evaluationCommentService;
        private readonly IEvaluationService _evaluationService;
        private readonly IEvaluationQuestionListService _evaluationQuestionListService;

        public HomeController(IEmployeeService employeeService, IUserService userService, IEvaluationQuestionService evaluationQuestionService, IEvaluationCommentService evaluationCommentService, IEvaluationService evaluationService, IEvaluationQuestionListService evaluationQuestionListService)
        {
            _employeeService = employeeService;
            _userService = userService;
            _evaluationQuestionService = evaluationQuestionService;
            _evaluationCommentService = evaluationCommentService;
            _evaluationService = evaluationService;
            _evaluationQuestionListService = evaluationQuestionListService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OwnedEvaluations()
        {
            var identity = AuthenticatedIdentity();
            var userEmail = identity.Email;
            if (userEmail != null)
            {
                var user = _userService.GetbyEmail(userEmail);
                var employee = _employeeService.GetById(user.EmployeeId);

                var viewmodel = new OwnedEvaluationsViewModel
                {
                    GivenEvaluations = _evaluationService.GetEvaluationViewByEvaluatedEmployeeId(employee.EmployeeId)
                };
            
                return View();
            }
            else
            {
                ErrorNotification("You are not loged in");
                return RedirectToAction("Index");
            }


        }

        public ActionResult AssignedEvaluations()
        {
            var identity = AuthenticatedIdentity();
            var userEmail = identity.Email;
            if (userEmail != null)
            {
                var viewmodel = new AssignedEvaluationsViewModel();
                
                var user =_userService.GetbyEmail(userEmail);
                var employee = _employeeService.GetById(user.EmployeeId);
                var employeeRoleList = _employeeService.GetEmployeeRoles(employee);

                if (employee.SupervisorId != null)
                {
                    var supervisor = _employeeService.GetById((int)employee.SupervisorId);
                    viewmodel.Supervisor = supervisor;
                }
                else
                {
                    viewmodel.Supervisor = new Employee();
                }

                if ( (employeeRoleList.Select(x=>x.RoleId == 1).FirstOrDefault())) //Manager 
                {
                    viewmodel.DepartmentWorkers = _employeeService.GetEmployeeDepartmentWorkers(employee);
                    viewmodel.PeerEmployees = _employeeService.GetDepartmentManagers().Where(x => x.EmployeeId != employee.EmployeeId).ToList();

                }else if (employeeRoleList.Select(x => x.RoleId == 2).FirstOrDefault()) //Expert
                {
                    viewmodel.DepartmentWorkers = new List<Employee>();
                    viewmodel.PeerEmployees = _employeeService.GetEmployeeDepartmentWorkers(employee);
                }else if (employeeRoleList.Select(x => x.RoleId == 5).FirstOrDefault()) //General Manager
                {
                    viewmodel.PeerEmployees = new List<Employee>();
                    viewmodel.DepartmentWorkers = _employeeService.GetDepartmentManagers().ToList();

                }

                if ((employeeRoleList.Select(x => x.RoleId == 1002).FirstOrDefault())) //ProjectLead 
                {
                    var employeeProject = _employeeService.GetEmployeeProject(employee);
                    viewmodel.ProjectMembers = _employeeService.GetProjectMember(employeeProject.ProjectId).Where(x=>x.EmployeeId != employee.EmployeeId).ToList();
                }
                else
                {
                    viewmodel.ProjectMembers = new List<Employee>();
                }


                 return View(viewmodel);
            }
            else
            {
                ErrorNotification("You are not loged in");
                return RedirectToAction("Index");
            }
            

        }

        #region EvaluateGetMethods

        
        public ActionResult EvaluatePeer(int employeeId)
        {

            var identity = AuthenticatedIdentity();
            var userEmail = identity.Email;
            if (userEmail != null)
            {
                var viewModel = new EvaluateViewModel();
                var user = _userService.GetbyEmail(userEmail);

                var employee = _employeeService.GetById(user.EmployeeId);
                var employeeView = _employeeService.GetEmployeeViewById(user.EmployeeId);
                var employeeRoleList = _employeeService.GetEmployeeRoles(employee);

                viewModel.EvaluatedEmployee = _employeeService.GetEmployeeViewById(employeeId);
                viewModel.Evaluation = new Evaluation();
                viewModel.EvaluatingEmployee = employeeView;
                viewModel.Comment = new EvaluationComment();


                if ((employeeRoleList.Select(x => x.RoleId == 1).FirstOrDefault())) //Manager 
                {
                    viewModel.Questions = _evaluationQuestionService.GetQuestionsByRole(1); //Manager Questions
                }
                else if (employeeRoleList.Select(x => x.RoleId == 3).FirstOrDefault())
                {
                    viewModel.Questions = _evaluationQuestionService.GetQuestionsByRole(3); //HeadOfDepartment Questions
                }
                else
                {
                   viewModel.Questions = _evaluationQuestionService.GetQuestionsByRole(2); //Expert Questions
 
                }

                
                viewModel.EvaluatedEmployeeProjects = _employeeService.GetEmployeeProject(_employeeService.GetById(user.EmployeeId));
                    


                return View(viewModel);
            }
            else
            {
                ErrorNotification("You are not loged in");
                return RedirectToAction("Index");
            }
            
        }

        public ActionResult EvaluateDepartmentalWorkers(int employeeId)
        {

            var identity = AuthenticatedIdentity();
            var userEmail = identity.Email;
            if (userEmail != null)
            {
                var viewModel = new EvaluateViewModel();
                var user = _userService.GetbyEmail(userEmail);

                var employeeView = _employeeService.GetEmployeeViewById(user.EmployeeId);

                viewModel.EvaluatedEmployee = _employeeService.GetEmployeeViewById(employeeId);
                viewModel.Evaluation = new Evaluation();
                viewModel.EvaluatingEmployee = employeeView;
                viewModel.Comment = new EvaluationComment();

                viewModel.Questions = _evaluationQuestionService.GetQuestionsByRole(2); //Expert Questions

                viewModel.EvaluatedEmployeeProjects = _employeeService.GetEmployeeProject(_employeeService.GetById(user.EmployeeId));




                return View(viewModel);
            }
            else
            {
                ErrorNotification("You are not loged in");
                return RedirectToAction("Index");
            }

        }

        public ActionResult EvaluateSupervisor(int evaluatedEmployeeId)
        {

            var identity = AuthenticatedIdentity();
            var userEmail = identity.Email;
            if (userEmail != null)
            {
                var viewModel = new EvaluateViewModel();
                var user = _userService.GetbyEmail(userEmail);
                var employee = _employeeService.GetById(user.EmployeeId);
                var evaluatedEmployee = _employeeService.GetById(evaluatedEmployeeId);
                var evaluatedEmployeeRoleList = _employeeService.GetEmployeeRoles(evaluatedEmployee);

                var employeeView = _employeeService.GetEmployeeViewById(user.EmployeeId);

                viewModel.EvaluatedEmployee = _employeeService.GetEmployeeViewById(evaluatedEmployeeId);
                viewModel.Evaluation = new Evaluation();
                viewModel.EvaluatingEmployee = employeeView;
                viewModel.Comment = new EvaluationComment();


                if ((evaluatedEmployeeRoleList.Select(x => x.RoleId == 1).FirstOrDefault())) //Manager 
                {
                    viewModel.Questions = _evaluationQuestionService.GetQuestionsByRole(1); //Manager Questions
                }
                else if(evaluatedEmployeeRoleList.Select(x => x.RoleId == 3).FirstOrDefault())
                {
                    viewModel.Questions = _evaluationQuestionService.GetQuestionsByRole(3); //HeadOfDepartment Questions
                }
                else if (evaluatedEmployeeRoleList.Select(x => x.RoleId == 5).FirstOrDefault())
                {
                    viewModel.Questions = _evaluationQuestionService.GetQuestionsByRole(5); //General Manager Questions
                }



                viewModel.EvaluatedEmployeeProjects = _employeeService.GetEmployeeProject(employee);





                return View(viewModel);
            }
            else
            {
                ErrorNotification("You are not loged in");
                return RedirectToAction("Index");
            }

        }

        public ActionResult EvaluateProjectMember(int employeeId)
        {

            var identity = AuthenticatedIdentity();
            var userEmail = identity.Email;
            if (userEmail != null)
            {
                var viewModel = new EvaluateViewModel();
                var user = _userService.GetbyEmail(userEmail);

                var employeeView = _employeeService.GetEmployeeViewById(user.EmployeeId);

                viewModel.EvaluatedEmployee = _employeeService.GetEmployeeViewById(employeeId);
                viewModel.Evaluation = new Evaluation();
                viewModel.EvaluatingEmployee = employeeView;
                viewModel.Comment = new EvaluationComment();

                viewModel.Questions = _evaluationQuestionService.GetQuestionsByRole(4); //Project Member Questions

                viewModel.EvaluatedEmployeeProjects = _employeeService.GetEmployeeProject(_employeeService.GetById(user.EmployeeId));





                return View(viewModel);
            }
            else
            {
                ErrorNotification("You are not loged in");
                return RedirectToAction("Index");
            }

        }



        #endregion

        #region EvaluatePostMethods
        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult EvaluatePeer(EvaluateViewModel evaluateViewModel)
        {
            //insert evaluation comment
            var eComment = new EvaluationComment
            {
                CommentText = evaluateViewModel.Comment.CommentText,
                CommentType = "Public"
            };
            var comment = _evaluationCommentService.Insert(eComment);

            //calculate score
            double score = 0;
            foreach (var item in evaluateViewModel.Questions)
            {
                score += int.Parse(item.QuestionText);
            }
            score = score / evaluateViewModel.Questions.Count;

            //insert evaluation

            var evaluation = new Evaluation
            {
                CommentId = comment.CommentId,
                Score = score,
                Year = System.DateTime.Today.Year,
                EmployeeId = evaluateViewModel.EvaluatedEmployee.EmployeeId,
                SubmittedEmployeeId = evaluateViewModel.EvaluatingEmployee.EmployeeId
            };

            var insertedEvalutaion = _evaluationService.Insert(evaluation);

            //insert evaluation question list
            foreach (var item in evaluateViewModel.Questions)
            {
                var evalQuestion = new EvaluationQuestionList
                {
                    QuestionId = item.QuestionId,
                    EvaluationId = insertedEvalutaion.EvaluationId,
                    GivenRating = int.Parse(item.QuestionText)

                };
                _evaluationQuestionListService.Insert(evalQuestion);
            }


            return RedirectToAction("AssignedEvaluations");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult EvaluateDepartmentalWorkers(EvaluateViewModel evaluateViewModel)
        {
            //insert evaluation comment
            var eComment = new EvaluationComment
            {
                CommentText = evaluateViewModel.Comment.CommentText,
                CommentType = "Public"
            };
            var comment = _evaluationCommentService.Insert(eComment);

            //calculate score
            double score = 0;
            foreach (var item in evaluateViewModel.Questions)
            {
                score += int.Parse(item.QuestionText);
            }
            score = score / evaluateViewModel.Questions.Count;

            //insert evaluation

            var evaluation = new Evaluation
            {
                CommentId = comment.CommentId,
                Score = score,
                Year = System.DateTime.Today.Year,
                EmployeeId = evaluateViewModel.EvaluatedEmployee.EmployeeId,
                SubmittedEmployeeId = evaluateViewModel.EvaluatingEmployee.EmployeeId
            };

            var insertedEvalutaion = _evaluationService.Insert(evaluation);

            //insert evaluation question list
            foreach (var item in evaluateViewModel.Questions)
            {
                var evalQuestion = new EvaluationQuestionList
                {
                    QuestionId = item.QuestionId,
                    EvaluationId = insertedEvalutaion.EvaluationId,
                    GivenRating = int.Parse(item.QuestionText)
                };
                _evaluationQuestionListService.Insert(evalQuestion);
            }

            return RedirectToAction("AssignedEvaluations");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult EvaluateSupervisor(EvaluateViewModel evaluateViewModel)
        {
            //insert evaluation comment
            var eComment = new EvaluationComment
            {
                CommentText = evaluateViewModel.Comment.CommentText,
                CommentType = "Public"
            };
            var comment = _evaluationCommentService.Insert(eComment);

            //calculate score
            double score = 0;
            foreach (var item in evaluateViewModel.Questions)
            {
                score += int.Parse(item.QuestionText);
            }
            score = score / evaluateViewModel.Questions.Count;

            //insert evaluation

            var evaluation = new Evaluation
            {
                CommentId = comment.CommentId,
                Score = score,
                Year = System.DateTime.Today.Year,
                EmployeeId = evaluateViewModel.EvaluatedEmployee.EmployeeId,
                SubmittedEmployeeId = evaluateViewModel.EvaluatingEmployee.EmployeeId
            };

            var insertedEvalutaion = _evaluationService.Insert(evaluation);

            //insert evaluation question list
            foreach (var item in evaluateViewModel.Questions)
            {
                var evalQuestion = new EvaluationQuestionList
                {
                    QuestionId = item.QuestionId,
                    EvaluationId = insertedEvalutaion.EvaluationId,
                    GivenRating = int.Parse(item.QuestionText)
                };
                _evaluationQuestionListService.Insert(evalQuestion);
            }

            return RedirectToAction("AssignedEvaluations");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult EvaluateProjectMember(EvaluateViewModel evaluateViewModel)
        {
            //insert evaluation comment
            var eComment = new EvaluationComment
            {
                CommentText = evaluateViewModel.Comment.CommentText,
                CommentType = "Public"
            };
            var comment = _evaluationCommentService.Insert(eComment);

            //calculate score
            double score = 0;
            foreach (var item in evaluateViewModel.Questions)
            {
                score += int.Parse(item.QuestionText);
            }
            score = score / evaluateViewModel.Questions.Count;

            //insert evaluation

            var evaluation = new Evaluation
            {
                CommentId = comment.CommentId,
                Score = score,
                Year = System.DateTime.Today.Year,
                EmployeeId = evaluateViewModel.EvaluatedEmployee.EmployeeId,
                SubmittedEmployeeId = evaluateViewModel.EvaluatingEmployee.EmployeeId
            };

            var insertedEvalutaion = _evaluationService.Insert(evaluation);

            //insert evaluation question list
            foreach (var item in evaluateViewModel.Questions)
            {
                var evalQuestion = new EvaluationQuestionList
                {
                    QuestionId = item.QuestionId,
                    EvaluationId = insertedEvalutaion.EvaluationId,
                    GivenRating = int.Parse(item.QuestionText)
                };
                _evaluationQuestionListService.Insert(evalQuestion);
            }

            return RedirectToAction("AssignedEvaluations");
        }

        #endregion
        public ActionResult SearchEvaluations()
        {
          
            return View();
        }
        public ActionResult GetSearchEvaluationsList()
        {
            var identity = AuthenticatedIdentity();
            var userEmail = identity.Email;

            var user = _userService.GetbyEmail(userEmail);
            var employee = _employeeService.GetById(user.EmployeeId);

            List<EvaluationView> givenEvaluationList =
                _evaluationService.GetEvaluationViewByEvaluatingEmployeeId(employee.EmployeeId);


            return DataTableContent(givenEvaluationList);
        }

        public ActionResult OwnedEvaluationList()
        {
            var identity = AuthenticatedIdentity();
            var userEmail = identity.Email;
           
            var user = _userService.GetbyEmail(userEmail);
            var employee = _employeeService.GetById(user.EmployeeId);


            var takenEvaluationList = _evaluationService.GetEvaluationViewByEvaluatedEmployeeId(employee.EmployeeId);


            return DataTableContent(takenEvaluationList);
        }
    
    }
}