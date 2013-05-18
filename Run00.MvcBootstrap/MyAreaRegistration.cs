//using MvcContrib.PortableAreas;
//using System.Web.Mvc;

//namespace Run00.MvcBootstrap
//{
//	public class MyAreaRegistration : PortableAreaRegistration
//	{
		
//		public override string AreaName
//		{
//			get
//			{
//				return RazorEngine.RootAreaName;
//			}
//		}

//		public override void RegisterArea(AreaRegistrationContext context, IApplicationBus bus)
//		{
//			base.RegisterArea(context, bus);
//			context.MapRoute(
//					RazorEngine.RootAreaName + "_default",
//					RazorEngine.RootAreaName + "/{controller}/{action}/{id}",
//					new { action = "Index", id = UrlParameter.Optional },
//				 new[] { "Run00.MvcBootstrap.Areas.Controllers" }
//			);

//		}

//	}
//}