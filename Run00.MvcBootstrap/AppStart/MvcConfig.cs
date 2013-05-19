using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Run00.MvcBootstrap.AppStart
{
	public class MvcConfig : IAppStart
	{
		public MvcConfig(IControllerFactory factory, INamedApplicationViewEngine viewEngine)
		{
			_factory = factory;
			_viewEngine = viewEngine;
		}

		void IAppStart.Configure()
		{
			ControllerBuilder.Current.SetControllerFactory(_factory);
			ViewEngines.Engines.Clear();
			ViewEngines.Engines.Add(_viewEngine as IViewEngine);
		}

		private readonly IControllerFactory _factory;
		private readonly INamedApplicationViewEngine _viewEngine;
	}
}
