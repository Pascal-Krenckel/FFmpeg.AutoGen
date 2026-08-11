using FFmpeg.AutoGen.Native;
using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen;

public static class FunctionResolverFactory
{
    private static readonly OSPlatform Android = OSPlatform.Create("ANDROID");
    private static readonly OSPlatform IOS = OSPlatform.Create("IOS");
    public static PlatformID GetPlatformId()
    {

#if NETSTANDARD2_0_OR_GREATER
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            return PlatformID.Win32NT;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            return PlatformID.Unix;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            return PlatformID.MacOSX;
        return RuntimeInformation.IsOSPlatform(Android)
            ? PlatformID.Unix
            : RuntimeInformation.IsOSPlatform(IOS)
            ? PlatformID.Unix
            : OSDescriptionContains("android")
            ? PlatformID.Unix
            : OSDescriptionContains("ios") ? PlatformID.Unix : throw new PlatformNotSupportedException();
#else
        return Environment.OSVersion.Platform;

#endif
    }
    private static bool OSDescriptionContains(string os) =>
#if NETSTANDARD2_1_OR_GREATER
        RuntimeInformation.OSDescription.Contains(os, StringComparison.OrdinalIgnoreCase);
#else
         RuntimeInformation.OSDescription.ToLower().Contains(os);
#endif

    public static IFunctionResolver Create() => GetPlatformId() switch
    {
        PlatformID.MacOSX => new MacFunctionResolver(),
        PlatformID.Unix => new LinuxFunctionResolver(),
        PlatformID.Win32NT => new WindowsFunctionResolver(),
        _ => throw new PlatformNotSupportedException(),
    };
}
