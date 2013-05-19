using BoC.Web.Mvc.PrecompiledViews;
using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

namespace Run00.MvcBootstrap.AppStart
{
	public class NamedApplicationConfig : IAppStart
	{
		public NamedApplicationConfig(RouteCollection routes, INamedApplicationViewEngine engine)
		{
			_routes = routes;
			_engine = engine;
		}

		void IAppStart.Configure()
		{
			var appAssemblies =
				from a
				in AppDomain.CurrentDomain.GetAssemblies()
				let att = a.GetCustomAttributes(typeof(NamedApplicationAttribute), false).SingleOrDefault() as NamedApplicationAttribute
				where att != null
				select new { assembly = a, attribute = att };

			foreach (var loadedApp in appAssemblies)
			{
				var appName = loadedApp.attribute.Name;
				ApplicationPartRegistry.Register(loadedApp.assembly, "/Areas/" + appName);
				_engine.RegisterArea(appName);

				_routes.MapRoute(
						name: appName,
						url: "Areas/" + appName + "/{controller}/{action}/{id}",
						defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
				);
			}
		}

		private readonly RouteCollection _routes;
		private readonly INamedApplicationViewEngine _engine;
	}
}
