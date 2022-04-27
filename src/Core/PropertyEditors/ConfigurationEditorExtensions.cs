#if NET472
using Umbraco.Core.PropertyEditors;
using Umbraco.Core.Serialization;

namespace Umbraco.Community.Polyfill.Core.PropertyEditors
{
    public static class ConfigurationEditorExtensions
    {
        public static object FromDatabase(
            this IConfigurationEditor editor,
            string configurationJson,
            IConfigurationEditorJsonSerializer configurationEditorJsonSerializer)
        {
            return editor.FromDatabase(configurationJson);
        }
    }
}
#endif
