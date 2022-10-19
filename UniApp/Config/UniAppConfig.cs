using System;
using System.Web;
using System.Web.Http;
namespace UniApp.Config;

public class UniAppConfig
{
   public static void Register(HttpConfiguration config)
   {
      config.MapHttpAttributeRoutes();
      
      config.Routes.MapHttpRoute(
         name: "DefaultApi",
         routeTemplate: "api/{controller}/{id}",
         defaults: new { id = RouteParameter.Optional }
      );
   }
}