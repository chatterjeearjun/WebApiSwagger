using Microsoft.Web.Http.Description;
using Microsoft.Web.Http.Routing;
using Swagger.Net.Application;
using System;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Routing;

namespace WebApiSwagger
{
    /// <summary>
    /// Web API configuration.
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Registers Web API routes and services.
        /// </summary>
        /// <param name="configuration">Web API configuration.</param>
        public static void Register(HttpConfiguration configuration)
        {
            // Resolve attribute based route constraints.
            // Example: api/v{version:apiVersion}".
            var constraintResolver = new DefaultInlineConstraintResolver
            {
                ConstraintMap = { ["apiVersion"] = typeof(ApiVersionRouteConstraint) }
            };

            // Enable attribute based routing for Web API.
            configuration.MapHttpAttributeRoutes(constraintResolver);

            // Add Web API versioning service.
            configuration.AddApiVersioning();

            // Register Swagger service.
            configuration.RegisterSwagger(configuration.RegisterApiExplorer());
        }

        /// <summary>
        /// Register swagger.
        /// </summary>
        /// <param name="configuration">Web API configuration.</param>
        /// <param name="apiExplorer">Web API explorer.</param>
        private static void RegisterSwagger(this HttpConfiguration configuration, VersionedApiExplorer apiExplorer)
        {
            configuration.EnableSwagger(
                "{apiVersion}/swagger/docs",
                swagger =>
                {
                    swagger.MultipleApiVersions(
                        (apiDescription, version) => apiDescription.GetGroupName() == version,
                        info =>
                        {
                            foreach (var group in apiExplorer.ApiDescriptions)
                            {
                                var description = "Simple Web API description.";

                                if (group.IsDeprecated)
                                {
                                    description += " This Web API version has been deprecated.";
                                }

                                info.Version(group.Name, $"Simple Web API {group.ApiVersion}")
                                    .Contact(c => c.Name("John Smith").Email("john.smith@example.com"))
                                    .License(l => l.Name("MIT").Url("https://opensource.org/licenses/MIT"))
                                    .Description(description)
                                    .TermsOfService("Shareware");
                            }
                        });
                    swagger.PrettyPrint();
                    swagger.DescribeAllEnumsAsStrings();
                    swagger.Schemes(new[] { "http", "https" });
                    swagger.IncludeAllXmlComments(typeof(WebApiConfig).Assembly, AppDomain.CurrentDomain.BaseDirectory);
                })
                .EnableSwaggerUi(swagger =>
                {
                    swagger.DocumentTitle("Simple Web API");
                    swagger.CssTheme("theme-flattop-css");
                    swagger.EnableDiscoveryUrlSelector();
                });
        }

        /// <summary>
        /// Register API explorer.
        /// </summary>
        /// <param name="configuration">Web API configuration.</param>
        /// <returns>Configurated Web API explorer.</returns>
        private static VersionedApiExplorer RegisterApiExplorer(this HttpConfiguration configuration)
        {
            return configuration.AddVersionedApiExplorer(x =>
            {
                x.GroupNameFormat = string.Empty;
                x.SubstituteApiVersionInUrl = true;
            });
        }
    }
}
