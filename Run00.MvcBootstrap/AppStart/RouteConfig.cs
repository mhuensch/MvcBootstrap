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
		}

		private readonly RouteCollection _routes;
	}
}