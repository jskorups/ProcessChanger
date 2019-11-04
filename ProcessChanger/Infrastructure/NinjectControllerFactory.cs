using Ninject;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProcessChanger.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        public IKernel Kernel { get; }

        public NinjectControllerFactory(IKernel kernel)
        {
            this.Kernel = kernel;
          
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            IController controller = null;
           
            if (controllerType != null)
            {
                controller = (IController)Kernel.Get(controllerType);
            }
            return controller;
        }
    }
}