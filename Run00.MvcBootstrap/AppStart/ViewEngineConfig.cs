using Run00.WindsorMvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Run00.MvcBootstrap.AppStart
{
	public class ViewEngineConfig : IComponentConfiguration
	{
		public ViewEngineConfig(INamedApplicationViewEngine viewEngine)
		{
			_viewEngine = viewEngine;
		}

		void IComponentConfiguration.Configure()
		{
			ViewEngines.Engines.Clear();
			ViewEngines.Engines.Add(_viewEngine as IViewEngine);
		}

		private readonly INamedApplicationViewEngine _viewEngine;
	}
}
