﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Run00.MvcBootstrap
{
	public class EmbeddedResourceController : Controller
	{
		public ActionResult Resource(string path)
		{
			return File("", "");
		}
	}
}
