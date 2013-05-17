﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Caching;
using System.Web.Hosting;
using System.Web.WebPages;
using BoC.Web.Mvc.PrecompiledViews;

namespace BoC.Web.Mvc.PrecompiledViews
{
	public class CompiledVirtualPathProvider: VirtualPathProvider
	{
		/// <summary>
		/// Gets a value that indicates whether a file exists in the virtual file system.
		/// </summary>
		/// <returns>
		/// true if the file exists in the virtual file system; otherwise, false.
		/// </returns>
		/// <param name="virtualPath">The path to the virtual file.</param>
		public override bool FileExists(string virtualPath)
		{
			return
				GetCompiledType(virtualPath) != null 
				|| Previous.FileExists(virtualPath);
		}

		public Type GetCompiledType(string virtualPath)
		{
			return ApplicationPartRegistry.Instance.GetCompiledType(virtualPath);
		}

		/// <summary>
		/// Gets a virtual file from the virtual file system.
		/// </summary>
		/// <returns>
		/// A descendent of the <see cref="T:System.Web.Hosting.VirtualFile"/> class that represents a file in the virtual file system.
		/// </returns>
		/// <param name="virtualPath">The path to the virtual file.</param>
		public override VirtualFile GetFile(string virtualPath)
		{
						if (Previous.FileExists(virtualPath))
			{
								return Previous.GetFile(virtualPath);
			}
			var compiledType = GetCompiledType(virtualPath);
			if (compiledType != null)
			{
				return new CompiledVirtualFile(virtualPath, compiledType);
			}
			return null;
		}

				public override System.Web.Caching.CacheDependency GetCacheDependency(string virtualPath, System.Collections.IEnumerable virtualPathDependencies, DateTime utcStart)
				{
						if (virtualPathDependencies == null)
								return Previous.GetCacheDependency(virtualPath, virtualPathDependencies, utcStart);

						return Previous.GetCacheDependency(virtualPath, 
										from vp in virtualPathDependencies.Cast<string>()
										where GetCompiledType(vp) == null
										select vp
									, utcStart);
				}

	}
}