using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;

using System.Web.Mvc;
using System.Web.Routing;

using Ninject;

namespace Corporate_website_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute("IndexesRoute", "{controller}/{action}", new { controller= "Home", action = "Index" });







			//routes.MapRoute(
			//	"Default",                                              // Route name
			//	"{controller}/{action}/{id}",                           // URL with parameters
			//	new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
			//);

			//#region routes

			//routes.MapRoute(null, "",
			//	new
			//	{
			//		controller = "Home",
			//		action = "Index"
			//	}
			//);

			//routes.MapRoute(null, "about",
			//	new
			//	{
			//		controller = "About",
			//		action = "Index"
			//	}
			//);

			//routes.MapRoute(null, "reg",
			//	 new
			//	 {
			//		 controller = "Registration",
			//		 action = "Index"
			//	 }
			// );

			//routes.MapRoute(null, "auth",
			//	 new
			//	 {
			//		 controller = "Authentification",
			//		 action = "Index"
			//	 }
			// );

			//routes.MapRoute(
			//	name: "Default",
			//	url: "{controller}/{action}/{id}",
			//	defaults: new { controller = "Catalog", action = "Products", id = UrlParameter.Optional }
			//);

			//#endregion routes
		}
	}
}
