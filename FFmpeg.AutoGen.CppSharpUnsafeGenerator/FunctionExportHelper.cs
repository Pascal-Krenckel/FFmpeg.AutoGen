using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator;

internal static class FunctionExportHelper
{
    public static IEnumerable<FunctionExport> LoadFunctionExports(string path)
    {
        IEnumerable<string> libraries = Directory.EnumerateFiles(path, "*.dll");

        foreach (string libraryPath in libraries)
        {
            string libraryFullName = Path.GetFileNameWithoutExtension(libraryPath);
            string[] libraryNameParts = libraryFullName.Split('-');
            string libraryName = libraryNameParts[0];
            int libraryVersion = int.Parse(libraryNameParts[1]);

            IEnumerable<string> exports = GetExports(libraryPath);
            foreach (string export in exports)
                yield return new FunctionExport { LibraryName = libraryName, LibraryVersion = libraryVersion, Name = export };
        }
    }

    private static IEnumerable<string> GetExports(string library)
    {
        nint hCurrentProcess = Process.GetCurrentProcess().Handle;

        if (!SymInitialize(hCurrentProcess, null, false))
            throw new Exception("SymInitialize failed.");

        try
        {
            ulong baseOfDll = SymLoadModuleEx(hCurrentProcess, IntPtr.Zero, library, null, 0, 0, IntPtr.Zero, 0);
            if (baseOfDll == 0)
                throw new Exception($"SymLoadModuleEx failed for {library}.");

            var exports = new List<string>();

            bool EnumSyms(string name, ulong address, uint size, IntPtr context)
            {
                exports.Add(name);
                return true;
            }

            return !SymEnumerateSymbols64(hCurrentProcess, baseOfDll, EnumSyms, IntPtr.Zero)
                ? throw new Exception("SymEnumerateSymbols64 failed.")
                : (IEnumerable<string>)exports;
        }
        finally
        {
            _ = SymCleanup(hCurrentProcess);
        }
    }

    [DllImport("dbghelp", SetLastError = true, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SymInitialize(IntPtr hProcess, string userSearchPath, [MarshalAs(UnmanagedType.Bool)] bool fInvadeProcess);

    [DllImport("dbghelp", SetLastError = true, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SymCleanup(IntPtr hProcess);

    [DllImport("dbghelp", SetLastError = true, CharSet = CharSet.Unicode)]
    private static extern ulong SymLoadModuleEx(IntPtr hProcess, IntPtr hFile, string imageName, string moduleName, long baseOfDll, int dllSize, IntPtr data, int flags);

    [DllImport("dbghelp", SetLastError = true, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SymEnumerateSymbols64(IntPtr hProcess, ulong baseOfDll, SymEnumerateSymbolsProc64 enumSymbolsCallback, IntPtr userContext);

    private delegate bool SymEnumerateSymbolsProc64(string symbolName, ulong symbolAddress, uint symbolSize, IntPtr userContext);
}
