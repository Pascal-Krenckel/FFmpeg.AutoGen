using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate _AVClass* _AVClass_child_class_iterate (void** @iter);
public unsafe struct _AVClass_child_class_iterate_func
{
    public IntPtr Pointer;
    public static implicit operator _AVClass_child_class_iterate_func(_AVClass_child_class_iterate func) => new _AVClass_child_class_iterate_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void* _AVClass_child_next (void* @obj, void* @prev);
public unsafe struct _AVClass_child_next_func
{
    public IntPtr Pointer;
    public static implicit operator _AVClass_child_next_func(_AVClass_child_next func) => new _AVClass_child_next_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate _AVClassCategory _AVClass_get_category (void* @ctx);
public unsafe struct _AVClass_get_category_func
{
    public IntPtr Pointer;
    public static implicit operator _AVClass_get_category_func(_AVClass_get_category func) => new _AVClass_get_category_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate byte* _AVClass_item_name (void* @ctx);
public unsafe struct _AVClass_item_name_func
{
    public IntPtr Pointer;
    public static implicit operator _AVClass_item_name_func(_AVClass_item_name func) => new _AVClass_item_name_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int _AVClass_query_ranges (_AVOptionRanges** @p0, void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key, int @flags);
public unsafe struct _AVClass_query_ranges_func
{
    public IntPtr Pointer;
    public static implicit operator _AVClass_query_ranges_func(_AVClass_query_ranges func) => new _AVClass_query_ranges_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void _AVCodecContext_draw_horiz_band (_AVCodecContext* @s, _AVFrame* @src, ref int_array8 @offset, int @y, int @type, int @height);
public unsafe struct _AVCodecContext_draw_horiz_band_func
{
    public IntPtr Pointer;
    public static implicit operator _AVCodecContext_draw_horiz_band_func(_AVCodecContext_draw_horiz_band func) => new _AVCodecContext_draw_horiz_band_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int _AVCodecContext_execute (_AVCodecContext* @c, func_func @func, void* @arg2, int* @ret, int @count, int @size);
public unsafe struct _AVCodecContext_execute_func
{
    public IntPtr Pointer;
    public static implicit operator _AVCodecContext_execute_func(_AVCodecContext_execute func) => new _AVCodecContext_execute_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int _AVCodecContext_execute2 (_AVCodecContext* @c, func_func @func, void* @arg2, int* @ret, int @count);
public unsafe struct _AVCodecContext_execute2_func
{
    public IntPtr Pointer;
    public static implicit operator _AVCodecContext_execute2_func(_AVCodecContext_execute2 func) => new _AVCodecContext_execute2_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int _AVCodecContext_get_buffer2 (_AVCodecContext* @s, _AVFrame* @frame, int @flags);
public unsafe struct _AVCodecContext_get_buffer2_func
{
    public IntPtr Pointer;
    public static implicit operator _AVCodecContext_get_buffer2_func(_AVCodecContext_get_buffer2 func) => new _AVCodecContext_get_buffer2_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int _AVCodecContext_get_encode_buffer (_AVCodecContext* @s, _AVPacket* @pkt, int @flags);
public unsafe struct _AVCodecContext_get_encode_buffer_func
{
    public IntPtr Pointer;
    public static implicit operator _AVCodecContext_get_encode_buffer_func(_AVCodecContext_get_encode_buffer func) => new _AVCodecContext_get_encode_buffer_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate _AVPixelFormat _AVCodecContext_get_format (_AVCodecContext* @s, _AVPixelFormat* @fmt);
public unsafe struct _AVCodecContext_get_format_func
{
    public IntPtr Pointer;
    public static implicit operator _AVCodecContext_get_format_func(_AVCodecContext_get_format func) => new _AVCodecContext_get_format_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void _AVD3D11VADeviceContext_lock (void* @lock_ctx);
public unsafe struct _AVD3D11VADeviceContext_lock_func
{
    public IntPtr Pointer;
    public static implicit operator _AVD3D11VADeviceContext_lock_func(_AVD3D11VADeviceContext_lock func) => new _AVD3D11VADeviceContext_lock_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void _AVD3D11VADeviceContext_unlock (void* @lock_ctx);
public unsafe struct _AVD3D11VADeviceContext_unlock_func
{
    public IntPtr Pointer;
    public static implicit operator _AVD3D11VADeviceContext_unlock_func(_AVD3D11VADeviceContext_unlock func) => new _AVD3D11VADeviceContext_unlock_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int _AVFilterGraph_execute (_AVFilterContext* @ctx, func_func @func, void* @arg, int* @ret, int @nb_jobs);
public unsafe struct _AVFilterGraph_execute_func
{
    public IntPtr Pointer;
    public static implicit operator _AVFilterGraph_execute_func(_AVFilterGraph_execute func) => new _AVFilterGraph_execute_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int _AVFormatContext_control_message_cb (_AVFormatContext* @s, int @type, void* @data, ulong @data_size);
public unsafe struct _AVFormatContext_control_message_cb_func
{
    public IntPtr Pointer;
    public static implicit operator _AVFormatContext_control_message_cb_func(_AVFormatContext_control_message_cb func) => new _AVFormatContext_control_message_cb_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int _AVFormatContext_io_close2 (_AVFormatContext* @s, _AVIOContext* @pb);
public unsafe struct _AVFormatContext_io_close2_func
{
    public IntPtr Pointer;
    public static implicit operator _AVFormatContext_io_close2_func(_AVFormatContext_io_close2 func) => new _AVFormatContext_io_close2_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int _AVFormatContext_io_open (_AVFormatContext* @s, _AVIOContext** @pb,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, int @flags, _AVDictionary** @options);
public unsafe struct _AVFormatContext_io_open_func
{
    public IntPtr Pointer;
    public static implicit operator _AVFormatContext_io_open_func(_AVFormatContext_io_open func) => new _AVFormatContext_io_open_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void _AVHWDeviceContext_free (_AVHWDeviceContext* @ctx);
public unsafe struct _AVHWDeviceContext_free_func
{
    public IntPtr Pointer;
    public static implicit operator _AVHWDeviceContext_free_func(_AVHWDeviceContext_free func) => new _AVHWDeviceContext_free_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void _AVHWFramesContext_free (_AVHWFramesContext* @ctx);
public unsafe struct _AVHWFramesContext_free_func
{
    public IntPtr Pointer;
    public static implicit operator _AVHWFramesContext_free_func(_AVHWFramesContext_free func) => new _AVHWFramesContext_free_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int _AVIOContext_read_packet (void* @opaque, byte* @buf, int @buf_size);
public unsafe struct _AVIOContext_read_packet_func
{
    public IntPtr Pointer;
    public static implicit operator _AVIOContext_read_packet_func(_AVIOContext_read_packet func) => new _AVIOContext_read_packet_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int _AVIOContext_read_pause (void* @opaque, int @pause);
public unsafe struct _AVIOContext_read_pause_func
{
    public IntPtr Pointer;
    public static implicit operator _AVIOContext_read_pause_func(_AVIOContext_read_pause func) => new _AVIOContext_read_pause_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate long _AVIOContext_read_seek (void* @opaque, int @stream_index, long @timestamp, int @flags);
public unsafe struct _AVIOContext_read_seek_func
{
    public IntPtr Pointer;
    public static implicit operator _AVIOContext_read_seek_func(_AVIOContext_read_seek func) => new _AVIOContext_read_seek_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate long _AVIOContext_seek (void* @opaque, long @offset, int @whence);
public unsafe struct _AVIOContext_seek_func
{
    public IntPtr Pointer;
    public static implicit operator _AVIOContext_seek_func(_AVIOContext_seek func) => new _AVIOContext_seek_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate ulong _AVIOContext_update_checksum (ulong @checksum, byte* @buf, uint @size);
public unsafe struct _AVIOContext_update_checksum_func
{
    public IntPtr Pointer;
    public static implicit operator _AVIOContext_update_checksum_func(_AVIOContext_update_checksum func) => new _AVIOContext_update_checksum_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int _AVIOContext_write_data_type (void* @opaque, byte* @buf, int @buf_size, _AVIODataMarkerType @type, long @time);
public unsafe struct _AVIOContext_write_data_type_func
{
    public IntPtr Pointer;
    public static implicit operator _AVIOContext_write_data_type_func(_AVIOContext_write_data_type func) => new _AVIOContext_write_data_type_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int _AVIOContext_write_packet (void* @opaque, byte* @buf, int @buf_size);
public unsafe struct _AVIOContext_write_packet_func
{
    public IntPtr Pointer;
    public static implicit operator _AVIOContext_write_packet_func(_AVIOContext_write_packet func) => new _AVIOContext_write_packet_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int _AVIOInterruptCB_callback (void* @p0);
public unsafe struct _AVIOInterruptCB_callback_func
{
    public IntPtr Pointer;
    public static implicit operator _AVIOInterruptCB_callback_func(_AVIOInterruptCB_callback func) => new _AVIOInterruptCB_callback_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void av_buffer_create_free (void* @opaque, byte* @data);
public unsafe struct av_buffer_create_free_func
{
    public IntPtr Pointer;
    public static implicit operator av_buffer_create_free_func(av_buffer_create_free func) => new av_buffer_create_free_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate _AVBufferRef* av_buffer_pool_init_alloc (ulong @size);
public unsafe struct av_buffer_pool_init_alloc_func
{
    public IntPtr Pointer;
    public static implicit operator av_buffer_pool_init_alloc_func(av_buffer_pool_init_alloc func) => new av_buffer_pool_init_alloc_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate _AVBufferRef* av_buffer_pool_init2_alloc (void* @opaque, ulong @size);
public unsafe struct av_buffer_pool_init2_alloc_func
{
    public IntPtr Pointer;
    public static implicit operator av_buffer_pool_init2_alloc_func(av_buffer_pool_init2_alloc func) => new av_buffer_pool_init2_alloc_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void av_buffer_pool_init2_pool_free (void* @opaque);
public unsafe struct av_buffer_pool_init2_pool_free_func
{
    public IntPtr Pointer;
    public static implicit operator av_buffer_pool_init2_pool_free_func(av_buffer_pool_init2_pool_free func) => new av_buffer_pool_init2_pool_free_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void av_log_set_callback_callback (void* @p0, int @p1,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @p2, byte* @p3);
public unsafe struct av_log_set_callback_callback_func
{
    public IntPtr Pointer;
    public static implicit operator av_log_set_callback_callback_func(av_log_set_callback_callback func) => new av_log_set_callback_callback_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int av_tree_enumerate_cmp (void* @opaque, void* @elem);
public unsafe struct av_tree_enumerate_cmp_func
{
    public IntPtr Pointer;
    public static implicit operator av_tree_enumerate_cmp_func(av_tree_enumerate_cmp func) => new av_tree_enumerate_cmp_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int av_tree_enumerate_enu (void* @opaque, void* @elem);
public unsafe struct av_tree_enumerate_enu_func
{
    public IntPtr Pointer;
    public static implicit operator av_tree_enumerate_enu_func(av_tree_enumerate_enu func) => new av_tree_enumerate_enu_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int av_tree_find_cmp (void* @key, void* @b);
public unsafe struct av_tree_find_cmp_func
{
    public IntPtr Pointer;
    public static implicit operator av_tree_find_cmp_func(av_tree_find_cmp func) => new av_tree_find_cmp_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int av_tree_insert_cmp (void* @key, void* @b);
public unsafe struct av_tree_insert_cmp_func
{
    public IntPtr Pointer;
    public static implicit operator av_tree_insert_cmp_func(av_tree_insert_cmp func) => new av_tree_insert_cmp_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int avcodec_default_execute_func (_AVCodecContext* @c2, void* @arg2);
public unsafe struct avcodec_default_execute_func_func
{
    public IntPtr Pointer;
    public static implicit operator avcodec_default_execute_func_func(avcodec_default_execute_func func) => new avcodec_default_execute_func_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int avcodec_default_execute2_func (_AVCodecContext* @c2, void* @arg2, int @p2, int @p3);
public unsafe struct avcodec_default_execute2_func_func
{
    public IntPtr Pointer;
    public static implicit operator avcodec_default_execute2_func_func(avcodec_default_execute2_func func) => new avcodec_default_execute2_func_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int avio_alloc_context_read_packet (void* @opaque, byte* @buf, int @buf_size);
public unsafe struct avio_alloc_context_read_packet_func
{
    public IntPtr Pointer;
    public static implicit operator avio_alloc_context_read_packet_func(avio_alloc_context_read_packet func) => new avio_alloc_context_read_packet_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate long avio_alloc_context_seek (void* @opaque, long @offset, int @whence);
public unsafe struct avio_alloc_context_seek_func
{
    public IntPtr Pointer;
    public static implicit operator avio_alloc_context_seek_func(avio_alloc_context_seek func) => new avio_alloc_context_seek_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int avio_alloc_context_write_packet (void* @opaque, byte* @buf, int @buf_size);
public unsafe struct avio_alloc_context_write_packet_func
{
    public IntPtr Pointer;
    public static implicit operator avio_alloc_context_write_packet_func(avio_alloc_context_write_packet func) => new avio_alloc_context_write_packet_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int func (_AVFilterContext* @ctx, void* @arg, int @jobnr, int @nb_jobs);
public unsafe struct func_func
{
    public IntPtr Pointer;
    public static implicit operator func_func(func func) => new func_func { Pointer = func == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(func) };
}

