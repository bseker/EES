

using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.MvcUI.Areas.Admin.Infrastructure;
         
using EES.MvcUI.Areas.Admin.Models.UserModels;
        namespace EES.MvcUI.Areas.Admin.Controllers
{
    public class UserController : AdminController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        //[ChildActionOnly]
        public ActionResult List()
        {
            var user = _userService.GetAll();

            return DataTableContent(user);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new UserSaveViewModel
            {
                User = new User()
            };

            return View("Save",model);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            _userService.Insert(user);

            SuccessNotification("The item has been added");

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int userId)
        {
            var model = new UserSaveViewModel
            {
                User = _userService.GetById(userId)
            };

            return View("Save", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(User user)
        {
            _userService.Update(user);

            SuccessNotification("The item has been updated");

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int userId)
        {
            _userService.Delete(userId);

            SuccessNotification("The item has been deleted");

            return RedirectToAction("Index");
        }
    }
}
