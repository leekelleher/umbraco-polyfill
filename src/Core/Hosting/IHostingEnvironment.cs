#if NET472
namespace Umbraco.Core.Hosting
{
    // https://github.com/umbraco/Umbraco-CMS/blob/release-8.0.0/src/Umbraco.Core/IO/IOHelper.cs#L81-L114
    // https://github.com/umbraco/Umbraco-CMS/blob/release-9.0.0/src/Umbraco.Core/Hosting/IHostingEnvironment.cs
    // https://github.com/umbraco/Umbraco-CMS/blob/release-9.0.0/src/Umbraco.Web.Common/AspNetCore/AspNetCoreHostingEnvironment.cs#L135
    public interface IHostingEnvironment
    {
        string MapPathWebRoot(string path);
    }
}
#endif
