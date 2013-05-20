using System.Linq;
using System.Reflection;

namespace Run00.MvcBootstrap
{
	public static class ExtensionsForAssembly
	{
		public static NamedApplicationAttribute GetNamedApplicationAttribute(this Assembly assembly)
		{
			return assembly.GetCustomAttributes(typeof(NamedApplicationAttribute), false).SingleOrDefault() as NamedApplicationAttribute;
		}
	}
}
