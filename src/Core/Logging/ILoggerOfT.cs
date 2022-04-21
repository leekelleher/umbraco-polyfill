#if NET472
namespace Umbraco.Core.Logging
{
    public interface ILogger<out T> : ILogger
    { }
}
#endif
