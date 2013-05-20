using System.Web.Mvc;

namespace Run00.MvcBootstrap
{
	public interface IGenericControllerFactory
	{
		IController Create(type));
		void Release(IController controller);
	}
}
