using Castle.Windsor;
using Castle.Windsor.Installer;
using Presentation.CastleWindsor;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Presentation
{
    // Nota: para obtener instrucciones sobre cómo habilitar el modo clásico de IIS6 o IIS7, 
    // visite http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        WindsorContainer _windsorContainer;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            InitializeWindsor();
        }

        private void InitializeWindsor()
        {
            _windsorContainer = new WindsorContainer();
            _windsorContainer.Install(FromAssembly.This());
            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(_windsorContainer.Kernel));
        }
    }
}