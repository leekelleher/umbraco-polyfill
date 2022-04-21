#if NET472
using Umbraco.Core.Composing;
using Umbraco.Core.Hosting;
using Umbraco.Core.IO;
using Umbraco.Core.Logging;
using Umbraco.Core.Serialization;

namespace Umbraco.Core.Runtime
{
    [ComposeAfter(typeof(CoreRuntimeComposer))]
    [RuntimeLevel(MinLevel = RuntimeLevel.Boot)]
    internal sealed class UmbracoPolyfillComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.RegisterAuto(typeof(ILogger<>), typeof(UmbracoPolyfillLogger<>));

            composition.RegisterUnique<IHostingEnvironment, AspNetFxHostingEnvironment>();

            composition.RegisterUnique<IIOHelper, IOHelperPolyfill>();

            composition.RegisterUnique<IJsonSerializer, UmbracoPolyfillJsonSerializer>();
        }
    }
}
#endif
