#if NET472
namespace Umbraco.Core
{
    // https://github.com/umbraco/Umbraco-CMS/blob/release-8.0.0/src/Umbraco.Core/Udi.cs
    // https://github.com/umbraco/Umbraco-CMS/blob/release-8.0.0/src/Umbraco.Core/GuidUdi.cs
    // https://github.com/umbraco/Umbraco-CMS/blob/release-8.0.0/src/Umbraco.Core/StringUdi.cs
    // https://github.com/umbraco/Umbraco-CMS/blob/release-9.0.0/src/Umbraco.Core/UdiParser.cs
    public sealed class UdiParser
    {
        public static Udi Parse(string s) => Udi.Parse(s);

        public static Udi Parse(string s, bool knownTypes) => Udi.Parse(s, knownTypes);

        public static bool TryParse(string s, out Udi udi) => Udi.TryParse(s, out udi);

        public static bool TryParse(string s, out GuidUdi udi) => GuidUdi.TryParse(s, out udi);

        public static bool TryParse(string s, out StringUdi udi) => StringUdi.TryParse(s, out udi);

        public static bool TryParse(string s, bool knownTypes, out Udi udi) => Udi.TryParse(s, knownTypes, out udi);
    }
}
#endif
