namespace Run00.MvcBootstrap.TestHost
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			_bootstrap.Start();
		}

		public override void Dispose()
		{
			_bootstrap.Dispose();
			base.Dispose();
		}

		private readonly Bootstrap _bootstrap = new Bootstrap();
	}
}