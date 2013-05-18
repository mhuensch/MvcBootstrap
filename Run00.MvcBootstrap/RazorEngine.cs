using System.Linq;
using System.Web.Mvc;

namespace Run00.MvcBootstrap
{
	public class RazorEngine : RazorViewEngine
	{
		public const string RootAreaName = "Areas";
		private static string[] NewPartialViewFormats = new[] {
				"~/"+RazorEngine.RootAreaName+"/Views/{1}/{0}.cshtml",
		};

		public RazorEngine()
		{
			base.ViewLocationFormats = base.PartialViewLocationFormats.Union(NewPartialViewFormats).ToArray();
		}

		protected override IView CreateView(ControllerContext controllerContext, string viewPath, string masterPath)
		{
			return base.CreateView(controllerContext, viewPath, masterPath);
		}

	}
}