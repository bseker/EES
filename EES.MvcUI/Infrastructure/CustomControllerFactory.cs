

using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
 
using EES.Business.DependencyResolvers.Ninject;
        
namespace EES.MvcUI.Infrastructure
{
    public class CustomControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel _kernel;

        public CustomControllerFactory()
        {
            _kernel = new StandardKernel(new BusinessModule());
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_kernel.Get(controllerType);
        }
    }
}

