using System.Web;
using System.Web.Mvc;

namespace Run00.MvcBootstrap.TestHost
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}