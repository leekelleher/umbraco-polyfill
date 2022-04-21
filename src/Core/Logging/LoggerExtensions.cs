#if NET472
using System;

namespace Umbraco.Core.Logging
{
    public static class LoggerExtensions
    {
        public static bool IsEnabled<T>(this ILogger<T> logger, LogLevel level) => logger.IsEnabled(typeof(T), level);

        public static void Log<T>(this ILogger<T> logger, LogLevel logLevel, string message, params object[] args) => logger.Info(typeof(T), message, args);

        public static void LogCritical<T>(this ILogger<T> logger, Exception exception, string message, params object[] args) => logger.Fatal(typeof(T), exception, message, args);

        public static void LogCritical<T>(this ILogger<T> logger, string message, params object[] args) => logger.Fatal(typeof(T), message, args);

        public static void LogDebug<T>(this ILogger<T> logger, string message, params object[] args) => logger.Debug(typeof(T), message, args);

        public static void LogError<T>(this ILogger<T> logger, Exception exception, string message, params object[] args) => logger.Error(typeof(T), exception, message, args);

        public static void LogError<T>(this ILogger<T> logger, string message, params object[] args) => logger.Error(typeof(T), message, args);

        public static void LogInformation<T>(this ILogger<T> logger, string message, params object[] args) => logger.Info(typeof(T), message, args);

        public static void LogTrace<T>(this ILogger<T> logger, string message, params object[] args) => logger.Debug(typeof(T), message, args);

        public static void LogWarning<T>(this ILogger<T> logger, Exception exception, string message, params object[] args) => logger.Warn(typeof(T), exception, message, args);

        public static void LogWarning<T>(this ILogger<T> logger, string message, params object[] args) => logger.Warn(typeof(T), message, args);
    }
}
#endif
