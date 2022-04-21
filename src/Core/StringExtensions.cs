#if NET472
using Umbraco.Core.Strings;

namespace Umbraco.Core
{
    // https://github.com/umbraco/Umbraco-CMS/blob/release-8.0.0/src/Umbraco.Core/StringExtensions.cs
    // https://github.com/umbraco/Umbraco-CMS/blob/release-9.0.0/src/Umbraco.Core/Extensions/StringExtensions.cs
    public static class StringExtensions
    {
        public static string ToSafeAlias(this string alias, IShortStringHelper shortStringHelper) => alias.ToSafeAlias();

        public static string ToSafeAlias(this string alias, IShortStringHelper shortStringHelper, bool camel) => alias.ToSafeAlias(camel);

        public static string ToSafeAlias(this string alias, IShortStringHelper shortStringHelper, string culture) => alias.ToSafeAlias(culture);

        public static string ToUrlSegment(this string text, IShortStringHelper shortStringHelper, string culture) => text.ToUrlSegment(culture);

        public static string ToCleanString(this string text, IShortStringHelper shortStringHelper, CleanStringType stringType) => text.ToCleanString(stringType);

        public static string ToCleanString(this string text, IShortStringHelper shortStringHelper, CleanStringType stringType, char separator) => text.ToCleanString(stringType, separator);

        public static string ToCleanString(this string text, IShortStringHelper shortStringHelper, CleanStringType stringType, string culture) => text.ToCleanString(stringType, culture);

        public static string SplitPascalCasing(this string phrase, IShortStringHelper shortStringHelper) => phrase.SplitPascalCasing();

        public static string ToSafeFileName(this string text, IShortStringHelper shortStringHelper) => text.ToSafeFileName();

        public static string ToSafeFileName(this string text, IShortStringHelper shortStringHelper, string culture) => text.ToSafeFileName(culture);
    }
}
#endif
