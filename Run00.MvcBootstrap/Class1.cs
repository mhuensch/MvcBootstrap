using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run00.MvcBootstrap
{
	public static class ServiceFactoryExtensions
	{
		public static object Create(this IGenericControllerFactory factory, Type serviceType)
		{
			return typeof(IGenericControllerFactory).GetMethod("Create")
					.MakeGenericMethod(serviceType)
					.Invoke(factory, new object[] { });
		}
	}
}
