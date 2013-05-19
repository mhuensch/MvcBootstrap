using BoC.Web.Mvc.PrecompiledViews;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using System;
using System.Web;
using System.Web.Mvc;
using System.Linq;

namespace Run00.MvcBootstrap
{
	public class Bootstrap : IDisposable
	{
		public void Start()
		{
			AreaRegistration.RegisterAllAreas();

			_container.Install(FromAssembly.InDirectory(new AssemblyFilter(HttpRuntime.BinDirectory)));

			var configs = _container.ResolveAll<IAppStart>();
			foreach (var config in configs)
				config.Configure();

			foreach (var config in configs)
				_container.Release(config);
		}

		public void Dispose()
		{
			_container.Dispose();
		}

		private readonly IWindsorContainer _container = new WindsorContainer();
	}
}
