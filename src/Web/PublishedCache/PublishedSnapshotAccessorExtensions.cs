#if NET472
namespace Umbraco.Web.PublishedCache
{
    // https://github.com/umbraco/Umbraco-CMS/blob/release-8.0.0/src/Umbraco.Web/PublishedCache/IPublishedSnapshotAccessor.cs#L8
    // https://github.com/umbraco/Umbraco-CMS/blob/release-9.0.0/src/Umbraco.Core/Extensions/PublishedSnapshotAccessorExtensions.cs
    public static class PublishedSnapshotAccessorExtensions
    {
        public static IPublishedSnapshot GetRequiredPublishedSnapshot(this IPublishedSnapshotAccessor accessor)
        {
            return accessor.PublishedSnapshot;
        }
    }
}
#endif
