using System.Web.Mvc;
using Newtonsoft.Json;

namespace EES.MvcUI.Infrastructure
{
    public class BaseContoller : Controller
    {
        protected internal ContentResult DataTableContent(object data)
        {
            return Content(JsonConvert.SerializeObject(new { data = data }), "application/json");
        }

        protected virtual void WarningNotification(string message, string title = "", bool persistForTheNextRequest = true)
        {
            AddNotification("warning", message, title, persistForTheNextRequest);
        }

        protected virtual void InfoNotification(string message, string title = "", bool persistForTheNextRequest = true)
        {
            AddNotification("info", message, title, persistForTheNextRequest);
        }

        protected virtual void SuccessNotification(string message, string title = "", bool persistForTheNextRequest = true)
        {
            AddNotification("success", message, title, persistForTheNextRequest);
        }

        protected virtual void ErrorNotification(string message, string title = "", bool persistForTheNextRequest = true)
        {
            AddNotification("error", message, title, persistForTheNextRequest);
        }

        private void AddNotification(string type, string message, string title, bool persistForTheNextRequest)
        {
            const string dataKey = "notification";
            const string dataKeyType = "notificationType";
            const string dataKeyTitle = "notificationTitle";

            if (persistForTheNextRequest)
            {
                TempData[dataKey] = message;
                TempData[dataKeyType] = type;
                TempData[dataKeyTitle] = title;
            }
            else
            {
                ViewData[dataKey] = message;
                ViewData[dataKeyType] = type;
                ViewData[dataKeyTitle] = title;
            }
        }
    }
}