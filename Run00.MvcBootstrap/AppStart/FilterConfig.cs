using Run00;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Run00.MvcBootstrap.AppStart
{
	public class AppStartFilterConfig : IAppStart
	{
		public AppStartFilterConfig(GlobalFilterCollection filterCollection, IEnumerable<IMvcFilter> mvcFilters)
		{
			_filterCollection = filterCollection;
			_mvcFilters = mvcFilters;
		}

		void IAppStart.Configure()
		{
			foreach (var filter in _mvcFilters)
				_filterCollection.Add(filter);
		}

		private readonly GlobalFilterCollection _filterCollection;
		private readonly IEnumerable<IMvcFilter> _mvcFilters;
	}
}