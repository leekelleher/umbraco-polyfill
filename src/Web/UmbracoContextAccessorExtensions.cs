#if NET472
namespace Umbraco.Web
{
    // https://github.com/umbraco/Umbraco-CMS/blob/release-8.0.0/src/Umbraco.Web/IUmbracoContextAccessor.cs
    // https://github.com/umbraco/Umbraco-CMS/blob/release-9.0.0/src/Umbraco.Core/Extensions/UmbracoContextAccessorExtensions.cs
    public static class UmbracoContextAccessorExtensions
    {
        public static UmbracoContext GetRequiredUmbracoContext(this IUmbracoContextAccessor accessor)
        {
            return accessor.UmbracoContext;
        }
    }
}
#endif
