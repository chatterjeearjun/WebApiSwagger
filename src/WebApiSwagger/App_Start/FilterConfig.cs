using System.Web.Mvc;

namespace WebApiSwagger
{
    /// <summary>
    /// Filter configuration.
    /// </summary>
    public static class FilterConfig
    {
        /// <summary>
        /// Registers global filters.
        /// </summary>
        /// <param name="filters">Global filter collection.</param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
