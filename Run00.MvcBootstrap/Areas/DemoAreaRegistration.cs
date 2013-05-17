//using MvcContrib.PortableAreas;
//using System.Web.Mvc;

//namespace Run00.MvcBootstrap.Areas.Demo
//{
//	public class DemoAreaRegistration : PortableAreaRegistration
//	{
//		public override string AreaName
//		{
//			get
//			{
//				return "Demo";
//			}
//		}

//		public override void RegisterArea(AreaRegistrationContext context, IApplicationBus bus)
//		{
//			//base.RegisterArea(context);
//			RegisterDefaultRoutes(context);
//			RegisterRoutes(context);
//			RegisterAreaEmbeddedResources();
//		}

//		private void RegisterRoutes(AreaRegistrationContext context)
//		{
//			//context.MapRoute(
//			//		AreaName + "_scripts",
//			//		base.AreaRoutePrefix + "/Scripts/{resourceName}",
//			//		new { controller = "EmbeddedResource", action = "Index", resourceName = "scripts" },
//			//		new[] { "Run00.MvcBootstrap.Areas.Demo.Controllers" }
//			//);

//			//context.MapRoute(
//			//		AreaName + "_images",
//			//		base.AreaRoutePrefix + "/images/{resourceName}",
//			//		new { controller = "EmbeddedResource", action = "Index", resourceName = "images" },
//			//		new[] { "Run00.MvcBootstrap.Areas.Demo.Controllers" }
//			//);

//			//context.MapRoute(
//			//		AreaName + "_content",
//			//		base.AreaRoutePrefix + "Content/{resourceName}",
//			//		new { controller = "EmbeddedResource", action = "Index", resourceName = "Content" },
//			//		new[] { "Run00.MvcBootstrap.Areas.Demo.Controllers" }
//			//);

//			context.MapRoute(
//					AreaName + "_default",
//					"Areas/{controller}/{action}/{id}",
//					new { action = "Index", id = UrlParameter.Optional },
//				 new[] { "Run00.MvcBootstrap.Areas.Controllers"}
//			);
//		}
//	}
//}