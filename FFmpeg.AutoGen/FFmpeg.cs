using System;
using System.Runtime.CompilerServices;

namespace FFmpeg.AutoGen;

public static partial class ffmpeg
{
    public static readonly int EAGAIN;

    public static readonly int ENOMEM = 12;

    public static readonly int EINVAL = 22;

    public static readonly int EPIPE = 32;
    
    static ffmpeg()
    {
        EAGAIN = FunctionResolverFactory.GetPlatformId() switch
        {
            PlatformID.MacOSX => 35,
            _ => 11
        };

        DynamicallyLoadedBindings.Initialize();
    }


    /// <summary>
    ///     Gets or sets the root path for loading libraries. <br/>
    ///     Set to null to search for it. <br/>
    ///     Use ';' as seperator if the libs are in different dirs <br/>
    ///     Work out of box with companion ffmpeg distribution package like FFmpeg.AutoGen.Redist.windows.x64
    /// </summary>
    /// <value>The root path.</value>
    #if NETSTANDARD2_1_OR_GREATER
    [System.Diagnostics.CodeAnalysis.AllowNull]
    #endif
    public static string RootPath { get; set; } = null;

    public static ulong UINT64_C<T>(T a)
        => Convert.ToUInt64(a);

    public static int AVERROR<T1>(T1 a)
        => -Convert.ToInt32(a);

    public static int MKTAG<T1, T2, T3, T4>(T1 a, T2 b, T3 c, T4 d)
        => (int)(Convert.ToUInt32(a) | (Convert.ToUInt32(b) << 8) | (Convert.ToUInt32(c) << 16) |
                 (Convert.ToUInt32(d) << 24));

    public static int FFERRTAG<T1, T2, T3, T4>(T1 a, T2 b, T3 c, T4 d)
        => -MKTAG(a, b, c, d);

    public static int FFALIGN(int x, int a)  => (((x) + (a) - 1) & ~((a) - 1));
    public static uint FFALIGN(uint x, uint a) => (((x) + (a) - 1) & ~((a) - 1));

    public static long FFALIGN(long x, long a) => (((x) + (a) - 1) & ~((a) - 1));
    public static ulong FFALIGN(ulong x, ulong a) => (((x) + (a) - 1) & ~((a) - 1));

    public static int AV_VERSION_INT<T1, T2, T3>(T1 a, T2 b, T3 c) =>
        (Convert.ToInt32(a) << 16) | (Convert.ToInt32(b) << 8) | Convert.ToInt32(c);

    public static string AV_VERSION_DOT<T1, T2, T3>(T1 a, T2 b, T3 c)
        => $"{a}.{b}.{c}";

    public unsafe static string TAG_TO_STRING(uint tag) => System.Text.Encoding.ASCII.GetString((byte*)&tag, 4);

    public static string AV_VERSION<T1, T2, T3>(T1 a, T2 b, T3 c)
        => AV_VERSION_DOT(a, b, c);

    /// <summary>Convert an AVRational to a <see cref="TimeSpan"/>.</summary>
    /// <param name="a">AVRational to convert</param>
    /// <returns>`a` in as System.TimeSpan</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TimeSpan av_q2TimeSpan(_AVRational @a)
    {
        return TimeSpan.FromTicks((long)a.num * 10_000_000 / a.den);
    }
}
