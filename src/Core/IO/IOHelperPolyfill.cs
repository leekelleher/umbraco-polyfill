#if NET472
namespace Umbraco.Core.IO
{
    internal sealed class IOHelperPolyfill : IIOHelper
    {
        public void EnsurePathExists(string path) => IOHelper.EnsurePathExists(path);

        public string FindFile(string virtualPath) => IOHelper.FindFile(virtualPath);

        public bool PathStartsWith(string path, string root, params char[] separators) => IOHelper.PathStartsWith(path, root, separators[0]);
    }
}
#endif
