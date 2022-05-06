#if NET472
namespace Microsoft.AspNetCore.Hosting
{
    // https://github.com/dotnet/aspnetcore/blob/v6.0.0/src/Hosting/Abstractions/src/IWebHostEnvironment.cs
    public interface IWebHostEnvironment
    {
        string MapPathWebRoot(string path);
    }
}
#endif
