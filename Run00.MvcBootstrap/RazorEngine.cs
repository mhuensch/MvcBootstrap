using System.Linq;
using System.Web.Mvc;

namespace Run00.MvcBootstrap
{
	public class RazorEngine : RazorViewEngine
	{
		private static string[] NewPartialViewFormats = new[] {
				"~/Areas/Views/{1}/{0}.cshtml",
		};

		public RazorEngine()
		{
			base.ViewLocationFormats = base.PartialViewLocationFormats.Union(NewPartialViewFormats).ToArray();
		}
	}
}