using System.Web.Mvc;
using System.Web.Routing;
using Ch.TimeTweet.Infrastructure.Configuration;

namespace Ch.TimeTweet.Presentation.Web
{  
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Routenname
                "{controller}/{action}/{id}", // URL mit Parametern
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameterstandardwerte
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
            ControllerBuilder.Current.SetControllerFactory(new NinjectMvcControllerFactory());            
        }
    }
}