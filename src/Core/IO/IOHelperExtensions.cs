#if NET472
namespace Umbraco.Core.IO
{
    // https://github.com/umbraco/Umbraco-CMS/blob/release-8.0.0/src/Umbraco.Core/IO/IOHelper.cs#L48-L63
    // https://github.com/umbraco/Umbraco-CMS/blob/release-9.0.0/src/Umbraco.Core/IO/IOHelperExtensions.cs#L16-L20
    public static class IOHelperExtensions
    {
        public static string ResolveRelativeOrVirtualUrl(this IIOHelper helper, string path) => IOHelper.ResolveVirtualUrl(path);
    }
}
#endif
