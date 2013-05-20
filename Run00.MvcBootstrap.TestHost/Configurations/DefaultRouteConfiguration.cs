using Run00.WindsorMvc;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

namespace Run00.MvcBootstrap.TestHost.Controllers
{
	public class AppStartRouteConfig : IComponentConfiguration
	{
		public AppStartRouteConfig(RouteCollection routes)
		{
			_routes = routes;
		}

		void IComponentConfiguration.Configure()
		{
			_routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

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