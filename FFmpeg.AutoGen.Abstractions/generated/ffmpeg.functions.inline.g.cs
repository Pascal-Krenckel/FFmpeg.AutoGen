using System;
using System.Runtime.CompilerServices;

namespace FFmpeg.AutoGen.Abstractions;

public static unsafe partial class ffmpeg
{
    /// <summary>Compute ceil(log2(x)).</summary>
    /// <param name="x">value used to compute ceil(log2(x))</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int av_ceil_log2_c(int @x)
    {
        return av_log2((uint)(x - 1U) << 1);
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Clip a signed integer value into the amin-amax range.</summary>
    /// <param name="a">value to clip</param>
    /// <param name="amin">minimum value of the clip range</param>
    /// <param name="amax">maximum value of the clip range</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int av_clip_c(int @a, int @amin, int @amax)
    {
        if (a < amin)
            return amin;
        else if (a > amax)
            return amax;
        else
            return a;
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Clip a signed integer value into the -32768,32767 range.</summary>
    /// <param name="a">value to clip</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short av_clip_int16_c(int @a)
    {
        if (((a + 32768U) & ~65535) != 0)
            return (short)((a >> 31) ^ 32767);
        else
            return (short)a;
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Clip a signed integer value into the -128,127 range.</summary>
    /// <param name="a">value to clip</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte av_clip_int8_c(int @a)
    {
        if (((a + 128U) & ~255) != 0)
            return (sbyte)((a >> 31) ^ 127);
        else
            return (sbyte)a;
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Clip a signed integer into the -(2^p),(2^p-1) range.</summary>
    /// <param name="a">value to clip</param>
    /// <param name="p">bit position to clip at</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int av_clip_intp2_c(int @a, int @p)
    {
        if ((((uint)a + (1U << p)) & ~((2U << p) - 1)) != 0)
            return (a >> 31) ^ ((1 << p) - 1);
        else
            return a;
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Clip a signed integer value into the 0-65535 range.</summary>
    /// <param name="a">value to clip</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort av_clip_uint16_c(int @a)
    {
        if ((a & (~65535)) != 0)
            return (ushort)((~a) >> 31);
        else
            return (ushort)a;
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Clip a signed integer value into the 0-255 range.</summary>
    /// <param name="a">value to clip</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte av_clip_uint8_c(int @a)
    {
        if ((a & (~255)) != 0)
            return (byte)((~a) >> 31);
        else
            return (byte)a;
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Clip a signed integer to an unsigned power of two range.</summary>
    /// <param name="a">value to clip</param>
    /// <param name="p">bit position to clip at</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint av_clip_uintp2_c(int @a, int @p)
    {
        if ((a & ~((1U << p) - 1)) != 0)
            return (uint)(~a) >> 31 & ((1U << p) - 1);
        else
            return (uint)a;
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Clip a signed 64bit integer value into the amin-amax range.</summary>
    /// <param name="a">value to clip</param>
    /// <param name="amin">minimum value of the clip range</param>
    /// <param name="amax">maximum value of the clip range</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long av_clip64_c(long @a, long @amin, long @amax)
    {
        if (a < amin)
            return amin;
        else if (a > amax)
            return amax;
        else
            return a;
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Clip a double value into the amin-amax range. If a is nan or -inf amin will be returned. If a is +inf amax will be returned.</summary>
    /// <param name="a">value to clip</param>
    /// <param name="amin">minimum value of the clip range</param>
    /// <param name="amax">maximum value of the clip range</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double av_clipd_c(double @a, double @amin, double @amax)
    {
        return ((((a) > (amin) ? (a) : (amin))) > (amax) ? (amax) : (((a) > (amin) ? (a) : (amin))));
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Clip a float value into the amin-amax range. If a is nan or -inf amin will be returned. If a is +inf amax will be returned.</summary>
    /// <param name="a">value to clip</param>
    /// <param name="amin">minimum value of the clip range</param>
    /// <param name="amax">maximum value of the clip range</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float av_clipf_c(float @a, float @amin, float @amax)
    {
        return ((((a) > (amin) ? (a) : (amin))) > (amax) ? (amax) : (((a) > (amin) ? (a) : (amin))));
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Clip a signed 64-bit integer value into the -2147483648,2147483647 range.</summary>
    /// <param name="a">value to clip</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int av_clipl_int32_c(long @a)
    {
        if ((((ulong)a + (2147483648UL)) & ~(4294967295UL)) != 0)
            return (int)((a >> 63) ^ 2147483647);
        else
            return (int)a;
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Compare two rationals.</summary>
    /// <param name="a">First rational</param>
    /// <param name="b">Second rational</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int av_cmp_q(_AVRational @a, _AVRational @b)
    {
        long tmp = a.num * (long)b.den - b.num * (long)a.den;
        if (tmp != 0)
            return (int)((tmp ^ a.den ^ b.den) >> 63) | 1;
        else if (b.den != 0 && a.den != 0)
            return 0;
        else if (a.num != 0 && b.num != 0)
            return (a.num >> 31) - (b.num >> 31);
        else
            return (-2147483647 - 1);
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Reinterpret a double as a 64-bit integer.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong av_double2int(double @f)
    {
        return (ulong)@f;
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Reinterpret a float as a 32-bit integer.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint av_float2int(float @f)
    {
        return (uint)@f;
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Wrapper around av_frame_side_data_get_c() to workaround the limitation that for any type T the conversion from T * const * to const T * const * is not performed automatically in C.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static _AVFrameSideData* av_frame_side_data_get(_AVFrameSideData** @sd, int @nb_sd, _AVFrameSideDataType @type)
    {
        return av_frame_side_data_get_c(sd, nb_sd, type);
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Wrapper around av_image_copy() to workaround the limitation that the conversion from uint8_t * const * to const uint8_t * const * is not performed automatically in C.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void av_image_copy2(ref byte_ptr4 @dst_data, in int4 @dst_linesizes, ref byte_ptr4 @src_data, in int4 @src_linesizes, _AVPixelFormat @pix_fmt, int @width, int @height)
    {
        av_image_copy(ref dst_data, dst_linesizes, src_data, src_linesizes, pix_fmt, width, height);
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Reinterpret a 64-bit integer as a double.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double av_int2double(ulong @i)
    {
        return (double)@i;
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Reinterpret a 32-bit integer as a float.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float av_int2float(uint @i)
    {
        return (float)@i;
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Invert a rational.</summary>
    /// <param name="q">value</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static _AVRational av_inv_q(_AVRational @q)
    {
        var r = new _AVRational { @num = q.den, @den = q.num };
        return r;
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Fill the provided buffer with a string containing an error string corresponding to the AVERROR code errnum.</summary>
    /// <param name="errbuf">a buffer</param>
    /// <param name="errbuf_size">size in bytes of errbuf</param>
    /// <param name="errnum">error code to describe</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte* av_make_error_string(byte* @errbuf, ulong @errbuf_size, int @errnum)
    {
        av_strerror(errnum, errbuf, errbuf_size);
        return errbuf;
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Create an AVRational.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static _AVRational av_make_q(int @num, int @den)
    {
        var r = new _AVRational { @num = num, @den = den };
        return r;
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int av_parity_c(uint @v)
    {
        return av_popcount_c(v) & 1;
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Count number of bits set to one in x</summary>
    /// <param name="x">value to count bits of</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int av_popcount_c(uint @x)
    {
        x -= (x >> 1) & 1431655765;
        x = (x & 858993459) + ((x >> 2) & 858993459);
        x = (x + (x >> 4)) & 252645135;
        x += x >> 8;
        return (int)((x + (x >> 16)) & 63);
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Count number of bits set to one in x</summary>
    /// <param name="x">value to count bits of</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int av_popcount64_c(ulong @x)
    {
        return av_popcount_c((uint)x) + av_popcount_c((uint)(x >> 32));
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Convert an AVRational to a `double`.</summary>
    /// <param name="a">AVRational to convert</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double av_q2d(_AVRational @a)
    {
        return a.num / (double)a.den;
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Add two signed 32-bit values with saturation.</summary>
    /// <param name="a">one value</param>
    /// <param name="b">another value</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int av_sat_add32_c(int @a, int @b)
    {
        return av_clipl_int32_c((long)a + b);
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Add two signed 64-bit values with saturation.</summary>
    /// <param name="a">one value</param>
    /// <param name="b">another value</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long av_sat_add64_c(long @a, long @b)
    {
        try
        {
            return @a + @b;
        }
        catch (OverflowException)
        {
            return ((double)@a + (double)@b) > 0d ? long.MaxValue : long.MinValue;
        }
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Add a doubled value to another value with saturation at both stages.</summary>
    /// <param name="a">first value</param>
    /// <param name="b">value doubled and added to a</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int av_sat_dadd32_c(int @a, int @b)
    {
        return av_sat_add32_c(a, av_sat_add32_c(b, b));
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Subtract a doubled value from another value with saturation at both stages.</summary>
    /// <param name="a">first value</param>
    /// <param name="b">value doubled and subtracted from a</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int av_sat_dsub32_c(int @a, int @b)
    {
        return av_sat_sub32_c(a, av_sat_add32_c(b, b));
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Subtract two signed 32-bit values with saturation.</summary>
    /// <param name="a">one value</param>
    /// <param name="b">another value</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int av_sat_sub32_c(int @a, int @b)
    {
        return av_clipl_int32_c((long)a - b);
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Subtract two signed 64-bit values with saturation.</summary>
    /// <param name="a">one value</param>
    /// <param name="b">another value</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long av_sat_sub64_c(long @a, long @b)
    {
        try
        {
            return @a - @b;
        }
        catch (OverflowException)
        {
            return ((double)@a - (double)@b) > 0d ? long.MaxValue : long.MinValue;
        }
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Return x default pointer in case p is NULL.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void* av_x_if_null(void* @p, void* @x)
    {
        return (void*)(p != null ? p : x);
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>Clear high bits from an unsigned integer starting with specific bit position</summary>
    /// <param name="a">value to clip</param>
    /// <param name="p">bit position to clip at. Must be between 0 and 31.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint av_zero_extend_c(uint @a, uint @p)
    {
        return a & ((1U << (int)p) - 1);
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
    /// <summary>ftell() equivalent for AVIOContext.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long avio_tell(_AVIOContext* @s)
    {
        return avio_seek(s, 0, 1);
    }
    // original body hash: 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=
    
}
