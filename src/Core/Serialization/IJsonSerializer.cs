#if NET472
namespace Umbraco.Core.Serialization
{
    // https://github.com/umbraco/Umbraco-CMS/blob/release-9.0.0/src/Umbraco.Core/Serialization/IJsonSerializer.cs
    public interface IJsonSerializer
    {
        string Serialize(object input);

        T Deserialize<T>(string input);

        T DeserializeSubset<T>(string input, string key);
    }
}
#endif
