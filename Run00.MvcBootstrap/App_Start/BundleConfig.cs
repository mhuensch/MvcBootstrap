using System.Web.Optimization;

namespace Run00.MvcBootstrap
{
	public class BundleConfig
	{
		// For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
									"~/Areas/Demo/Scripts/jquery-1.8.2.min.js",
										"~/Areas/Demo/Scripts/jquery-1.8.2.js",
										"~/Areas/Demo/Scripts/jquery-1.8.2.intellisense.js"));


			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
									"~/Areas/Demo/Scripts/jquery.validate.unobtrusive.js",
									"~/Areas/Demo/Scripts/jquery.validate.unobtrusive.min.js",
									"~/Areas/Demo/Scripts/jquery.validate.min.js",
									"~/Areas/Demo/Scripts/jquery.validate-vsdoc.js"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
									"~/Areas/Demo/Scripts/modernizr-2.6.2.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
									"~/Areas/Demo/Content/site.css"));

			bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
									"~/Areas/Demo/Content/themes/base/jquery.ui.core.css",
									"~/Areas/Demo/Content/themes/base/jquery.ui.resizable.css",
									"~/Areas/Demo/Content/themes/base/jquery.ui.selectable.css",
									"~/Areas/Demo/Content/themes/base/jquery.ui.accordion.css",
									"~/Areas/Demo/Content/themes/base/jquery.ui.autocomplete.css",
									"~/Areas/Demo/Content/themes/base/jquery.ui.button.css",
									"~/Areas/Demo/Content/themes/base/jquery.ui.dialog.css",
									"~/Areas/Demo/Content/themes/base/jquery.ui.slider.css",
									"~/Areas/Demo/Content/themes/base/jquery.ui.tabs.css",
									"~/Areas/Demo/Content/themes/base/jquery.ui.datepicker.css",
									"~/Areas/Demo/Content/themes/base/jquery.ui.progressbar.css",
									"~/Areas/Demo/Content/themes/base/jquery.ui.theme.css"));
		}
	}
}