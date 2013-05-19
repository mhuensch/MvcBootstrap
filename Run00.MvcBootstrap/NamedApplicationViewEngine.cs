using System.Linq;
using System.Web.Mvc;

namespace Run00.MvcBootstrap
{
	public class NamedApplicationViewEngine : RazorViewEngine, INamedApplicationViewEngine
	{
		public void RegisterArea(string areaName)
		{
			base.ViewLocationFormats = base.ViewLocationFormats.Union(new[] { "~/Areas/" + areaName + "/Views/{1}/{0}.cshtml" }).ToArray();
		}

		protected override IView CreateView(ControllerContext controllerContext, string viewPath, string masterPath)
		{
			return base.CreateView(controllerContext, viewPath, masterPath);
		}

	}
}