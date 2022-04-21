#if NET472
using Umbraco.Core.IO;

namespace Umbraco.Core.Hosting
{
    internal sealed class AspNetFxHostingEnvironment : IHostingEnvironment
    {
        public string MapPathWebRoot(string path)
        {
            return IOHelper.MapPath(path);
        }
    }
}
#endif
