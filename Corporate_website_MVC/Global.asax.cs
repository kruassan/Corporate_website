using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

//using Corporate_website_Domain.Entity_framework;
using Corporate_website_Domain.EntityFramework.Contexts;
namespace Corporate_website_MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
			AreaRegistration.RegisterAllAreas();
			RouteConfig.RegisterRoutes(RouteTable.Routes);

			ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());
		}
    }
}
