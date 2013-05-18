using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Run00.MvcBootstrap.TestHost
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{

			AreaRegistration.RegisterAllAreas();

			WebApiConfig.Register(GlobalConfiguration.Configuration);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			//BundleConfig.RegisterBundles(BundleTable.Bundles);
			AuthConfig.RegisterAuth();

			ViewEngines.Engines.Clear();
			ViewEngines.Engines.Add(new RazorEngine());

			BoC.Web.Mvc.PrecompiledViews.ApplicationPartRegistry.Register(typeof(Run00.MvcBootstrap.Areas.Controllers.WorldController).Assembly);
		}
	}


}