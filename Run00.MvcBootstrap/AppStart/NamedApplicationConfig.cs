using BoC.Web.Mvc.PrecompiledViews;
using Run00.WindsorMvc;
using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

namespace Run00.MvcBootstrap.AppStart
{
	public class NamedApplicationConfig : IComponentConfiguration
	{
		public NamedApplicationConfig(RouteCollection routes, INamedApplicationViewEngine engine)
		{
			_routes = routes;
			_engine = engine;
		}

		void IComponentConfiguration.Configure()
		{
			var appAssemblies =
				from a
				in AppDomain.CurrentDomain.GetAssemblies()
				let att = a.GetNamedApplicationAttribute()
				where att != null
				select new { assembly = a, attribute = att };

			foreach (var loadedApp in appAssemblies)
			{
				var appName = loadedApp.attribute.Name;
				ApplicationPartRegistry.Register(loadedApp.assembly, "/Areas/" + appName);
				_engine.RegisterArea("Areas/" + appName);

				var controllerNamespace = loadedApp.assembly.FullName.Split(',').ElementAt(0) + ".Controllers";

				_routes.MapRoute(
						name: appName,
						url: "Areas/{area}/{controller}/{action}/{id}",
						defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
						namespaces: new string[] { controllerNamespace },
						constraints: new { area = new AreaRouteConstraint() }
				);
			}
		}

		private class AreaRouteConstraint : IRouteConstraint
		{
			bool IRouteConstraint.Match(System.Web.HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
			{
				if (values["area"] == null)
					return false;

				if (string.IsNullOrWhiteSpace(values["area"].ToString()))
					return false;

				return true;
			}
		}

		private readonly RouteCollection _routes;
		private readonly INamedApplicationViewEngine _engine;
	}
}
