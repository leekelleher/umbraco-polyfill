﻿#if NET472
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Umbraco.Core.PropertyEditors;

namespace Umbraco.Core.Serialization
{
    // https://github.com/umbraco/Umbraco-CMS/blob/release-9.0.0/src/Umbraco.Core/Serialization/IConfigurationEditorJsonSerializer.cs
    public interface IConfigurationEditorJsonSerializer : IJsonSerializer
    { }

    // https://github.com/umbraco/Umbraco-CMS/blob/release-9.0.0/src/Umbraco.Infrastructure/Serialization/ConfigurationEditorJsonSerializer.cs
    internal sealed class ConfigurationEditorJsonSerializer : UmbracoPolyfillJsonSerializer, IConfigurationEditorJsonSerializer
    {
        public ConfigurationEditorJsonSerializer()
        {
            JsonSerializerSettings.Converters.Add(new FuzzyBooleanConverter());
            JsonSerializerSettings.ContractResolver = new ConfigurationCustomContractResolver();
        }

        private class ConfigurationCustomContractResolver : DefaultContractResolver
        {
            protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
            {
                // base.CreateProperty deals with [JsonProperty("name")]
                var property = base.CreateProperty(member, memberSerialization);

                // override with our custom attribute, if any
                var attribute = member.GetCustomAttribute<ConfigurationFieldAttribute>();
                if (attribute != null) property.PropertyName = attribute.Key;

                // for value types,
                //  don't try to deserialize nulls (in legacy json)
                //  no impact on serialization (value cannot be null)
                if (member is PropertyInfo propertyInfo && propertyInfo.PropertyType.IsValueType)
                    property.NullValueHandling = NullValueHandling.Ignore;

                return property;
            }
        }
    }
}
#endif
