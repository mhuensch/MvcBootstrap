using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;

namespace Run00.MvcBootstrap.TestHost.Controllers
{
	public class AppStartRouteConfig : IAppStart
	{
		public AppStartRouteConfig(RouteCollection routes)
		{
			_routes = routes;
		}

		void IAppStart.Configure()
		{
			_routes.MapRoute(
					name: "Default",
					url: "{controller}/{action}/{id}",
					defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
					namespaces: new string[] { this.GetType().Assembly.FullName.Split(',').ElementAt(0) + ".Controllers" }
			);
		}

		private readonly RouteCollection _routes;
	}
}