using Swagger.Net.Application;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApiSwagger
{
    /// <summary>
    /// Route configuration.
    /// </summary>
    public static class RouteConfig
    {
        /// <summary>
        /// Registers global routes.
        /// </summary>
        /// <param name="routes">Route collection.</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Ignore trace path.
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Set Swagger portal as a home page.
            routes.MapHttpRoute(
               name: "Swagger_root",
               defaults: null,
               constraints: null,
               routeTemplate: string.Empty,
               handler: new RedirectHandler(m => $"{m.RequestUri}", "swagger")
            );
        }
    }
}
