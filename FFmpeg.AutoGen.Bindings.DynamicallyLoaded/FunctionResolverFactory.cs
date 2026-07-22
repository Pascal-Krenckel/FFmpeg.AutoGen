using FFmpeg.AutoGen.Bindings.DynamicallyLoaded.Native;
using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Bindings.DynamicallyLoaded;

public static class FunctionResolverFactory
{
    private readonly static OSPlatform Android = OSPlatform.Create("ANDROID");
    private readonly static OSPlatform IOS = OSPlatform.Create("IOS");
    public static PlatformID GetPlatformId()
    {

#if NETSTANDARD2_0_OR_GREATER
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return PlatformID.Win32NT;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) return PlatformID.Unix;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) return PlatformID.MacOSX;
        if (RuntimeInformation.IsOSPlatform(Android)) return PlatformID.Unix;
        if (RuntimeInformation.IsOSPlatform(IOS)) return PlatformID.Unix;
        if (OSDescriptionContains("android")) return PlatformID.Unix;
        if (OSDescriptionContains("ios"))  return PlatformID.Unix;
        throw new PlatformNotSupportedException();
#else
        return Environment.OSVersion.Platform;

#endif
    }
    private static bool OSDescriptionContains(string os)
    {
#if NETSTANDARD2_1_OR_GREATER
        return RuntimeInformation.OSDescription.Contains(os, StringComparison.OrdinalIgnoreCase);
#else
        return RuntimeInformation.OSDescription.ToLower().Contains(os);
#endif
    }
    public static IFunctionResolver Create()
    {
        return GetPlatformId() switch
        {
            PlatformID.MacOSX => new MacFunctionResolver(),
            PlatformID.Unix => new LinuxFunctionResolver(),
            PlatformID.Win32NT => new WindowsFunctionResolver(),
            _ => throw new PlatformNotSupportedException(),
        };
    }
}
