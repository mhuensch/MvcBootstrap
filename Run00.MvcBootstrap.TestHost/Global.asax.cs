using Castle.Windsor;
using Run00.WindsorMvc;

namespace Run00.MvcBootstrap.TestHost
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			_bootstrap.InstallFromBin();
			_bootstrap.ConfigureComponents();
		}

		public override void Dispose()
		{
			_bootstrap.Dispose();
			base.Dispose();
		}

		private readonly IWindsorContainer _bootstrap = new WindsorContainer();
	}
}