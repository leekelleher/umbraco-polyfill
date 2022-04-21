#if NET472
namespace Umbraco.Core.IO
{
    // https://github.com/umbraco/Umbraco-CMS/blob/release-8.0.0/src/Umbraco.Core/IO/IOHelper.cs
    // https://github.com/umbraco/Umbraco-CMS/blob/release-9.0.0/src/Umbraco.Core/IO/IIOHelper.cs
    public interface IIOHelper
    {
        string FindFile(string virtualPath);

        bool PathStartsWith(string path, string root, params char[] separators);

        void EnsurePathExists(string path);
    }
}
#endif
