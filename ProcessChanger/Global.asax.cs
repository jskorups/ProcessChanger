using Ninject;
using ProcessChanger.Infrastructure;
using ProcessChanger.Models;
using ProcessChanger.Repositories;
using ProcessChanger.Validators;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ProcessChanger
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
     
            IKernel kernel = new StandardKernel();

            kernel.Bind<IUserRepository>().To<UserInMemoryRepository>().InSingletonScope();

            kernel.Bind<IModelValidator<AddUserModel>>().To<AddUserModelValidator>();
            kernel.Bind<IModelValidator<EditUserModel>>().To<EditUserModelValidator>();

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory(kernel));
        }
    }
}
