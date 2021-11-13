

using System;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using EES.MvcUI.Infrastructure;
using Mitras.Core.CrossCuttingConcerns.Security.Web;

namespace EES.MvcUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            ControllerBuilder.Current.SetControllerFactory(new CustomControllerFactory());

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine()); 
        }

        public override void Init()
        {
            PostAuthenticateRequest += MvcApplication_PostAuthenticateRequest;
            base.Init();
        }

        void MvcApplication_PostAuthenticateRequest(object sender, EventArgs e)
        {
            try
            {
                var authCookie = HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];
                if (authCookie == null) return;

                var encTicket = authCookie.Value;
                if (String.IsNullOrEmpty(encTicket)) return;

                var ticket = FormsAuthentication.Decrypt(encTicket);

                var securityUtilities = new SecurityUtilities();
                var identity = securityUtilities.FormsAuthTicketToIdentity(ticket);
                var prin = new GenericPrincipal(identity, identity.Roles);

                HttpContext.Current.User = prin;
                Thread.CurrentPrincipal = prin;
            }
            catch (Exception)
            {
            }
        }
    }
}

