using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Bindings.DynamicallyLoaded;

public abstract class FunctionResolverBase : IFunctionResolver
{
    public static readonly Dictionary<string, string[]> LibraryDependenciesMap =
        new()
        {
            { "avcodec", new[] { "avutil", "swresample" } },
            { "avdevice", new[] { "avcodec", "avfilter", "avformat", "avutil" } },
            { "avfilter", new[] { "avcodec", "avformat", "avutil", "swresample", "swscale" } },
            { "avformat", new[] { "avcodec", "avutil" } },
            { "avutil", [] },
            { "swresample", new[] { "avutil" } },
            { "swscale", new[] { "avutil" } }
        };

    private readonly Dictionary<string, IntPtr> _loadedLibraries = [];

    private readonly object _syncRoot = new();

    public T GetFunctionDelegate<T>(string libraryName, string functionName, bool throwOnError = true)
    {
        var nativeLibraryHandle = GetOrLoadLibrary(libraryName, throwOnError);
        return GetFunctionDelegate<T>(nativeLibraryHandle, functionName, throwOnError);
    }

    public T GetFunctionDelegate<T>(IntPtr nativeLibraryHandle, string functionName, bool throwOnError)
    {
        var functionPointer = FindFunctionPointer(nativeLibraryHandle, functionName);

        if (functionPointer == IntPtr.Zero)
        {
            if (throwOnError)
                throw new EntryPointNotFoundException($"Could not find the entrypoint for {functionName}.");
            return default;
        }

#if NETSTANDARD2_0_OR_GREATER
        try
        {
            return Marshal.GetDelegateForFunctionPointer<T>(functionPointer);
        }
        catch (MarshalDirectiveException)
        {
            if (throwOnError)
                throw;
            return default;
        }
#else
        return (T)(object)Marshal.GetDelegateForFunctionPointer(functionPointer, typeof(T));
#endif
    }

    public IntPtr GetOrLoadLibrary(string libraryName, bool throwOnError)
    {
        if (_loadedLibraries.TryGetValue(libraryName, out var ptr))
            return ptr;

        lock (_syncRoot)
        {
            if (_loadedLibraries.TryGetValue(libraryName, out ptr))
                return ptr;

            var dependencies = LibraryDependenciesMap[libraryName];
            dependencies.Where(n => !_loadedLibraries.ContainsKey(n) && !n.Equals(libraryName))
                .ToList()
                .ForEach(n => GetOrLoadLibrary(n, false));

            var version = ffmpeg.LibraryVersionMap[libraryName];
            var nativeLibraryName = GetNativeLibraryName(libraryName, version);
            var libraryPath = FindLibrary(nativeLibraryName) ?? FindLibrary(libraryName);

            ptr = libraryPath != null ? LoadNativeLibrary(libraryPath) : IntPtr.Zero;

            if (ptr != IntPtr.Zero)
            {
                _loadedLibraries.Add(libraryName, ptr);
                var version_delegate = (Func<uint>)typeof(ffmpeg).GetMethod($"{libraryName}_version").CreateDelegate(typeof(Func<uint>));

                if ((version_delegate() >> 16) != version)
                {
                    _ = _loadedLibraries.Remove(libraryName);
                    if (throwOnError)
                        throw new DllNotFoundException(
                            $"Unable to load DLL '{libraryName}.{version} under {ffmpeg.RootPath}': The found library has the wrong version.");

                }
            }
            else if (throwOnError)
            {
                throw new DllNotFoundException(
                    $"Unable to load DLL '{libraryName}.{version} under {ffmpeg.RootPath}': The specified module could not be found.");
            }

            return ptr;
        }
    }

    private string FindLibrary(string libraryName)
    {
        IEnumerable<string> dirs = [];
        if (!string.IsNullOrEmpty(ffmpeg.RootPath))
        {
            dirs = (ffmpeg.RootPath.Split([';'], options: StringSplitOptions.RemoveEmptyEntries).Select(Environment.ExpandEnvironmentVariables));
        }
        else
        {
            dirs = dirs.Append(AppContext.BaseDirectory);
            dirs = dirs.Append(Path.Combine(AppContext.BaseDirectory, "ffmpeg"));
            dirs = dirs.Append(Path.Combine(AppContext.BaseDirectory, "ffmpeg", $"{GetOSLabel()}-{GetArchLabel()}"));
            string path = Environment.ExpandEnvironmentVariables(Environment.GetEnvironmentVariable("PATH"));
            dirs = dirs.Concat(path.Split(RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? ';' : ':'));
        }
        foreach (var dir in dirs)
        {
            string path = Path.Combine(dir, libraryName);
            if (File.Exists(path))
                return path;
            else if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                path = Path.Combine(dir, "lib" + libraryName);
                if (File.Exists(path))
                    return path;
            }
        }
        return null;
    }

    private string GetArchLabel() => RuntimeInformation.ProcessArchitecture switch
    {
        Architecture.X86 => "x32",
        Architecture.X64 => "x64",
        Architecture.Arm => "arm32",
        Architecture.Arm64 => "arm64",
        _ => ""
    };


    private string GetOSLabel()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            return "win";
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            return "linux";
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            return "osx";
        else
            return "";
    }
    protected abstract string GetNativeLibraryName(string libraryName, int version);
    protected abstract IntPtr LoadNativeLibrary(string libraryName);
    protected abstract IntPtr FindFunctionPointer(IntPtr nativeLibraryHandle, string functionName);
}
