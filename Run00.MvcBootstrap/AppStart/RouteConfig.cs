using System.Web.Mvc;
using System.Web.Routing;

namespace Run00.MvcBootstrap.AppStart
{
	public class AppStartRouteConfig : IAppStart
	{
		public AppStartRouteConfig(RouteCollection routes)
		{
			_routes = routes;
		}

		void IAppStart.Configure()
		{
			_routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			_routes.MapRoute(
					name: "Default",
					url: "{controller}/{action}/{id}",
					defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}

		private readonly RouteCollection _routes;
	}
}