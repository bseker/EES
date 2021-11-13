using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EES.Business.Abstract;
using EES.Entities.Concrete;
using EES.Entities.View;
using EES.MvcUI.Models.AuthModels;
using Mitras.Core.CrossCuttingConcerns.Security.Web;
using Mitras.Core.Utilities.Mvc.Infrastructure;

namespace EES.MvcUI.Controllers
{
    public class AuthController : BaseController
    {
        private readonly IUserService _userService;


        public AuthController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: Auth
       /* public ActionResult Index()
        {
            return View();
        }*/


        public ActionResult Login()
        {
            var model = new LoginModel { User = new UserEmployeeView() };
            return View(model);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel loginModel)
        {
            //var user = _userService.GetAll().FirstOrDefault(t => t.email == loginModel.User.email);
            var user = _userService.GeEmployeeUserbyEmail(loginModel.User.email);
            if (user != null)
            {
                if (user.UserRole == "IT")
                {
                    //IT User
                    AuthenticationHelper.CreateAuthCookie(default(Guid), user.email.ToString(), user.email, DateTime.Now.AddHours(1), new[] { "IT User" }, false, user.Name, user.Surname,"","");
                }
                else if (user.UserRole =="HR")
                {
                    //HR User
                    AuthenticationHelper.CreateAuthCookie(default(Guid), user.email.ToString(), user.email, DateTime.Now.AddHours(1), new[] { "HR User" }, false, user.Name, user.Surname, "", "");
                }
                else
                {
                    //Employee User
                    AuthenticationHelper.CreateAuthCookie(default(Guid), user.email.ToString(), user.email, DateTime.Now.AddHours(1), new[] { "Employee User" }, false, user.Name, user.Surname, "", "");
                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ErrorNotification("User Does Not Exists");
                return View();
            }

        }
        public ActionResult Logout()
        {
            if (HttpContext.Session != null)
            {
                HttpContext.Session.Clear();
                HttpContext.Session.Abandon();
            }
            HttpContext.User = null;
            System.Web.Security.FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}