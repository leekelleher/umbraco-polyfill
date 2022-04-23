## Community Polyfill for Umbraco

This project offers polyfills for classes, extensions and helpers, designed to support [Umbraco](https://github.com/umbraco/Umbraco-CMS/) package developers migrating and with multi-targeting both Umbraco 8 (.NET Fx 4.7.2) and Umbraco 9 (.NET 5.0).

The initial aim of the project is to polyfill Umbraco 8 to support newer Umbraco 9 APIs, in order to reduce the number of `#if`/`#else` preprocessor directives needed throughout the codebase of an Umbraco package.

---

**This project should be considered a continued work-in-progress, and NOT feature complete.**

If anything is missing, please send a pull request.

The polyfills so far have been to service the following Umbraco packages:

- [Contentment](https://github.com/leekelleher/umbraco-contentment)
- [Custom Value Converter](https://github.com/leekelleher/umbraco-custom-valueconverter)

