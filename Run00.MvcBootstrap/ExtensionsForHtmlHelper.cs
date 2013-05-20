using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace Run00.MvcBootstrap
{
	public static class ExtensionsForHtmlHelper
	{
		public static MvcHtmlString Action(this HtmlHelper helper, string actionName, string controllerName, string areaName)
		{
			return helper.Action(actionName, controllerName, new { area = areaName });
		}

		public static MvcHtmlString Action(this HtmlHelper helper, string actionName, string controllerName, string areaName, object routeValues)
		{
			return helper.Action(actionName, controllerName, areaName, new RouteValueDictionary(routeValues));
		}

		public static MvcHtmlString Action(this HtmlHelper helper, string actionName, string controllerName, string areaName, RouteValueDictionary routeValues)
		{
			routeValues.Add("area", areaName);
			return helper.Action(actionName, controllerName, routeValues);
		}
	}
}
