using System.Web.Mvc;
using System.Web.Routing;

namespace NetFlix
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //convension routing
            routes.MapRoute(
                name: "HelloNetflixByReleaseDate",
                url: "HelloNetflix/released/{year}/{month}",
                defaults: new { controller = "HelloNetFlix", action = "ByReleaseDate" },
                constraints: new { year = @"2015|2016", month = @"\d{2}" }
                );

            routes.MapRoute(
                name: "Hello",
                url: "{controller}/{action}/{name}/{id}"
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
