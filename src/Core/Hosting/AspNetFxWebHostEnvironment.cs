#if NET472
using Microsoft.AspNetCore.Hosting;
using Umbraco.Core.IO;

namespace Umbraco.Core.Hosting
{
    internal sealed class AspNetFxWebHostEnvironment : IWebHostEnvironment
    {
        public string MapPathWebRoot(string path)
        {
            return IOHelper.MapPath(path);
        }
    }
}
#endif
