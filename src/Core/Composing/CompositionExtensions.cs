#if NET472
using System;
using LightInject;

namespace Umbraco.Core.Composing
{
    // taken from: https://dev.to/mattbrailsford/adding-ilogger-t-support-to-umbraco-v8-5cg8
    // credit to: https://github.com/mattbrailsford
    internal static class CompositionExtensions
    {
        public static void RegisterAuto(this Composition composition, Type serviceBaseType, Type implementingBaseType)
        {
            if (composition.Concrete is ServiceContainer container)
            {
                container.RegisterFallback((serviceType, serviceName) =>
                {
                    if (serviceType.IsInterface &&
                        implementingBaseType.IsInterface == false &&
                        serviceType.IsGenericType &&
                        serviceType.GetGenericTypeDefinition() == serviceBaseType)
                    {
                        var genericArgs = serviceType.GetGenericArguments();
                        var implementingType = implementingBaseType.MakeGenericType(genericArgs);

                        container.Register(serviceType, implementingType);
                    }

                    return false;
                }, null);
            }
        }
    }
}
#endif
