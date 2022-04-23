## Community Polyfill for Umbraco

### What is it?

This library offers polyfills for classes, extensions and helpers, designed to support [Umbraco](https://github.com/umbraco/Umbraco-CMS/) package developers migrating and with multi-targeting both Umbraco 8 (.NET Fx 4.7.2) and Umbraco 9 (.NET 5.0).

The initial aim of the library is to polyfill Umbraco 8 to support newer Umbraco 9 APIs, in order to reduce the number of `#if`/`#else` preprocessor directives needed throughout the codebase of an Umbraco package.


### Installation

_**Please note,**_ this is not a stand-alone Umbraco package, it is a code library only, installable from NuGet only.

    dotnet add package Our.Umbraco.Community.Polyfill

> <https://www.nuget.org/packages/Our.Umbraco.Community.Polyfill>


### Roadmap

This library does not have a roadmap. **It should be considered a continued work-in-progress, and NOT feature complete.**

If anything is missing, please send a pull request.

Any additional polyfills will be added as-and-when they are needed. So far I am using this library to service the following Umbraco packages:

- [Contentment](https://github.com/leekelleher/umbraco-contentment)
- [Custom Value Converter](https://github.com/leekelleher/umbraco-custom-valueconverter)

If they need additional polyfills, then they'll be added to this library.


### Support

**Any feedback is welcome and appreciated.** But please keep in mind, I am not your personal support developer.


### License

Copyright &copy; [Lee Kelleher](https://leekelleher.com).

All source code is licensed under the [MIT License](../LICENSE).
