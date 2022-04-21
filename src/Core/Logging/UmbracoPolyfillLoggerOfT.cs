﻿#if NET472
using System;

namespace Umbraco.Core.Logging
{
    internal sealed class UmbracoPolyfillLogger<T> : ILogger<T>
    {
        private readonly ILogger _logger;

        public UmbracoPolyfillLogger(ILogger logger) => _logger = logger;

        public bool IsEnabled(Type reporting, LogLevel level) => _logger.IsEnabled(reporting, level);

        public void Fatal(Type reporting, Exception exception, string message) => _logger.Fatal(reporting, exception, message);

        public void Fatal(Type reporting, Exception exception) => _logger.Fatal(reporting, exception);

        public void Fatal(Type reporting, string message) => _logger.Fatal(reporting, message);

        public void Fatal(Type reporting, Exception exception, string messageTemplate, params object[] propertyValues) => _logger.Fatal(reporting, exception, messageTemplate, propertyValues);

        public void Fatal(Type reporting, string messageTemplate, params object[] propertyValues) => _logger.Fatal(reporting, messageTemplate, propertyValues);

        public void Error(Type reporting, Exception exception, string message) => _logger.Error(reporting, exception, message);

        public void Error(Type reporting, Exception exception) => _logger.Error(reporting, exception);

        public void Error(Type reporting, string message) => _logger.Error(reporting, message);

        public void Error(Type reporting, Exception exception, string messageTemplate, params object[] propertyValues) => _logger.Error(reporting, exception, messageTemplate, propertyValues);

        public void Error(Type reporting, string messageTemplate, params object[] propertyValues) => _logger.Error(reporting, messageTemplate, propertyValues);

        public void Warn(Type reporting, string message) => _logger.Warn(reporting, message);

        public void Warn(Type reporting, string messageTemplate, params object[] propertyValues) => _logger.Warn(reporting, messageTemplate, propertyValues);

        public void Warn(Type reporting, Exception exception, string message) => _logger.Warn(reporting, exception, message);

        public void Warn(Type reporting, Exception exception, string messageTemplate, params object[] propertyValues) => _logger.Warn(reporting, messageTemplate, propertyValues);

        public void Info(Type reporting, string message) => _logger.Info(reporting, message);

        public void Info(Type reporting, string messageTemplate, params object[] propertyValues) => _logger.Info(reporting, messageTemplate, propertyValues);

        public void Debug(Type reporting, string message) => _logger.Debug(reporting, message);

        public void Debug(Type reporting, string messageTemplate, params object[] propertyValues) => _logger.Debug(reporting, messageTemplate, propertyValues);

        public void Verbose(Type reporting, string message) => _logger.Verbose(reporting, message);

        public void Verbose(Type reporting, string messageTemplate, params object[] propertyValues) => _logger.Verbose(reporting, messageTemplate, propertyValues);
    }
}
#endif
