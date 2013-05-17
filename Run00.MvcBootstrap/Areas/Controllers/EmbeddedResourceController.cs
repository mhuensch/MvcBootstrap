using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Run00.MvcBootstrap.Areas.Demo.Controllers
{
	public class EmbeddedResourceController : Controller
	{
		public ActionResult Index(string resourceName)
		{
			var contentType = GetContentType(resourceName);
			var resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
			return this.File(resourceStream, contentType);
		}

		private static string GetContentType(string resourceName)
		{
			var extention = resourceName.Substring(resourceName.LastIndexOf('.')).ToLower();
			switch (extention)
			{
				case ".gif":
					return "image/gif";
				case ".js":
					return "text/javascript";
				case ".css":
					return "text/css";
				default:
					return "text/html";
			}
		}

	}
}
