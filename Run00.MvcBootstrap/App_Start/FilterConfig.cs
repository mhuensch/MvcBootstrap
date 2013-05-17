using System.Web;
using System.Web.Mvc;

namespace Run00.MvcBootstrap
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}