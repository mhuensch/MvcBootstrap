using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run00.MvcBootstrap
{
	[System.AttributeUsage(System.AttributeTargets.Assembly, AllowMultiple=false, Inherited=false)]
	public class NamedApplicationAttribute : Attribute
	{
		public string Name { get; private set; }
		public NamedApplicationAttribute(string name)
		{
			Name = name;
		}
	}
}