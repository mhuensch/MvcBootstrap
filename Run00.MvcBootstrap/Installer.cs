using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
//using System.Web.Optimization;

namespace Run00.MvcBootstrap
{
	public sealed class Installer : IWindsorInstaller
	{
		public void Install(IWindsorContainer container, IConfigurationStore store)
		{
			container.Register(Component.For<INamedApplicationViewEngine>().ImplementedBy<NamedApplicationViewEngine>().LifeStyle.Singleton);
		}
	}
}