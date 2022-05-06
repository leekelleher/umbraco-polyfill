#if NET5_0
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Web.Common.DependencyInjection;

namespace Microsoft.AspNetCore.Hosting
{
    // https://github.com/umbraco/Umbraco-CMS/blob/v10/contrib/src/Umbraco.Web.Common/Extensions/WebHostEnvironmentExtensions.cs
    internal static class WebHostEnvironmentExtensions
    {
        public static string MapPathWebRoot(this IWebHostEnvironment webHostEnvironment, string path)
        {
            var hostingEnvironment = StaticServiceProvider.Instance
                .GetRequiredService<Umbraco.Cms.Core.Hosting.IHostingEnvironment>();

            return hostingEnvironment.MapPathWebRoot(path);
        }
    }
}
#endif
