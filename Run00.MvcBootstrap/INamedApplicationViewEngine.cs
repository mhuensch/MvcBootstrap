using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Run00.MvcBootstrap
{
	public interface INamedApplicationViewEngine
	{
		void RegisterArea(string name);
	}
}
