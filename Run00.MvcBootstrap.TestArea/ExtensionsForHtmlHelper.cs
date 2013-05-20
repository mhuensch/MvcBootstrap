using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Run00.MvcBootstrap
{
	public static class ExtensionsForHtmlHelper
	{
		public static MvcHtmlString Action(this HtmlHelper helper, string actionName, string controllerName, string areaName)
		{
			return helper.Action(actionName, controllerName, new { area = areaName });
		}
	}
}
