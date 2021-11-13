using System;
using System.Web.Security;
using EES.MvcUI.Infrastructure;
using Mitras.Core.CrossCuttingConcerns.Security;
using Mitras.Core.CrossCuttingConcerns.Security.Web;

namespace EES.MvcUI.Areas.Admin.Infrastructure
{
    public class AdminController : BaseContoller
    {
        public Identity AuthenticatedIdentity()
        {
            Identity identity = new Identity();
            var authCookie = System.Web.HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];
            if (authCookie != null)
            {
                var encTicket = authCookie.Value;
                if (!String.IsNullOrEmpty(encTicket))
                {
                    var ticket = FormsAuthentication.Decrypt(encTicket);

                    var securityUtilities = new SecurityUtilities();
                    identity = securityUtilities.FormsAuthTicketToIdentity(ticket);
                }
            }
            return identity;
        }
    }
}