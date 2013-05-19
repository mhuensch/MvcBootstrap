using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Run00.MvcBootstrap.TestHost.Filters
{
	public class ErrorHandlerAttribute : HandleErrorAttribute, IAppFilter
	{
	}
}