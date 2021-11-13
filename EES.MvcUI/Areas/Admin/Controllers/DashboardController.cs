using System.Web.Mvc;
using EES.MvcUI.Areas.Admin.Infrastructure;

namespace EES.MvcUI.Areas.Admin.Controllers
{
    public class DashboardController : AdminController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}