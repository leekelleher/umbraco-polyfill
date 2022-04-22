#if NET472
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Umbraco.Core.Serialization
{
    // https://github.com/umbraco/Umbraco-CMS/blob/release-9.0.0/src/Umbraco.Infrastructure/Serialization/JsonNetSerializer.cs
    internal class UmbracoPolyfillJsonSerializer : IJsonSerializer
    {
        protected static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings()
        {
            Converters = new List<JsonConverter>()
            {
                new StringEnumConverter()
            }
        };

        public T Deserialize<T>(string input) => JsonConvert.DeserializeObject<T>(input, JsonSerializerSettings);

        public T DeserializeSubset<T>(string input, string key)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));

            var root = JsonConvert.DeserializeObject<JObject>(input);

            var jToken = root.SelectToken(key);

            switch (jToken)
            {
                case JArray jArray:
                    return jArray.ToObject<T>();

                case JObject jObject:
                    return jObject.ToObject<T>();

                default:
                    return jToken is null ? default : jToken.Value<T>();
            }
        }

        public string Serialize(object input) => JsonConvert.SerializeObject(input, JsonSerializerSettings);
    }
}
#endif
