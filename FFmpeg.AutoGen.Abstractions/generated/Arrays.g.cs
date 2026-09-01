using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Abstractions;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct _AVRational2 : IFixedArray<_AVRational>
{
    public static readonly int ArrayLength = 2;
    public readonly int Length => 2;
    #pragma warning disable CS9084
    _AVRational _0,_1;
    
    public ref _AVRational this[int i] 
    {
        get { CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public ref _AVRational this[uint i] 
    {
        get {  CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public _AVRational[] ToArray()
    {
        var a = new _AVRational[2];
        for (int i = 0; i < 2; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(_AVRational[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref _AVRational GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public Span<_AVRational> AsSpan() { fixed(void* ptr = &_0) return new Span<_AVRational>(ptr, 2); }
    public ReadOnlySpan<_AVRational> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<_AVRational>(ptr, 2); }
    public static implicit operator Span<_AVRational>(_AVRational2 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<_AVRational>(_AVRational2 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 2) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 2) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct double2 : IFixedArray<double>
{
    public static readonly int ArrayLength = 2;
    public readonly int Length => 2;
    fixed double _[2];
    
    public ref double this[int i] => ref _[i];
    public ref double this[uint i] => ref _[(int)i];
    public double[] ToArray()
    {
        var a = new double[2]; for (int i = 0; i < 2; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(double[] array)
    {
        int length = Math.Min(array.Length, 2);
        for(int i = 0; i < length; i++) _[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref double GetPinnableReference() => ref _[0];
    public Span<double> AsSpan() { fixed(void* ptr = _) return new Span<double>(ptr, 2); }
    public ReadOnlySpan<double> AsReadOnlySpan() { fixed(void* ptr = _) return new ReadOnlySpan<double>(ptr, 2); }
    public static implicit operator Span<double>(double2 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<double>(double2 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 2) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 2) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct short2 : IFixedArray<short>
{
    public static readonly int ArrayLength = 2;
    public readonly int Length => 2;
    fixed short _[2];
    
    public ref short this[int i] => ref _[i];
    public ref short this[uint i] => ref _[(int)i];
    public short[] ToArray()
    {
        var a = new short[2]; for (int i = 0; i < 2; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(short[] array)
    {
        int length = Math.Min(array.Length, 2);
        for(int i = 0; i < length; i++) _[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref short GetPinnableReference() => ref _[0];
    public Span<short> AsSpan() { fixed(void* ptr = _) return new Span<short>(ptr, 2); }
    public ReadOnlySpan<short> AsReadOnlySpan() { fixed(void* ptr = _) return new ReadOnlySpan<short>(ptr, 2); }
    public static implicit operator Span<short>(short2 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<short>(short2 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 2) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 2) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct void_ptr2 : IFixedPtrArray
{
    public static readonly int ArrayLength = 2;
    public readonly int Length => 2;
    #pragma warning disable CS9084
    void* _0,_1;
    
    public void* this[int i] 
    {
        readonly get { CheckIndex(i); fixed(void* ptr = &_0) return *((void**)ptr + i); }
        set { CheckIndex(i); fixed(void* ptr = &_0) *((void**)ptr + i) = value; }
    }
    public void* this[uint i] 
    {
        readonly get { CheckIndex(i); fixed(void* ptr = &_0) return *((void**)ptr + i); }
        set { CheckIndex(i); fixed(void* ptr = &_0) *((void**)ptr + i) = value; }
    }
    public readonly void*[] ToArray()
    {
        var a = new void*[2];
        for (int i = 0; i < 2; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(void*[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref void* GetPinnableReference() => ref _0;
    public Span<IntPtr> AsSpan() { fixed(void* ptr = &_0) return new Span<IntPtr>(ptr, 2); }
    public ReadOnlySpan<IntPtr> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<IntPtr>(ptr, 2); }
    #pragma warning restore CS9084
    public static implicit operator Span<IntPtr>(void_ptr2 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<IntPtr>(void_ptr2 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 2) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 2) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct _AVHDRPlusColorTransformParams3 : IFixedArray<_AVHDRPlusColorTransformParams>
{
    public static readonly int ArrayLength = 3;
    public readonly int Length => 3;
    #pragma warning disable CS9084
    _AVHDRPlusColorTransformParams _0,_1,_2;
    
    public ref _AVHDRPlusColorTransformParams this[int i] 
    {
        get { CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public ref _AVHDRPlusColorTransformParams this[uint i] 
    {
        get {  CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public _AVHDRPlusColorTransformParams[] ToArray()
    {
        var a = new _AVHDRPlusColorTransformParams[3];
        for (int i = 0; i < 3; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(_AVHDRPlusColorTransformParams[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref _AVHDRPlusColorTransformParams GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public Span<_AVHDRPlusColorTransformParams> AsSpan() { fixed(void* ptr = &_0) return new Span<_AVHDRPlusColorTransformParams>(ptr, 3); }
    public ReadOnlySpan<_AVHDRPlusColorTransformParams> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<_AVHDRPlusColorTransformParams>(ptr, 3); }
    public static implicit operator Span<_AVHDRPlusColorTransformParams>(_AVHDRPlusColorTransformParams3 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<_AVHDRPlusColorTransformParams>(_AVHDRPlusColorTransformParams3 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 3) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 3) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct _AVRational3 : IFixedArray<_AVRational>
{
    public static readonly int ArrayLength = 3;
    public readonly int Length => 3;
    #pragma warning disable CS9084
    _AVRational _0,_1,_2;
    
    public ref _AVRational this[int i] 
    {
        get { CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public ref _AVRational this[uint i] 
    {
        get {  CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public _AVRational[] ToArray()
    {
        var a = new _AVRational[3];
        for (int i = 0; i < 3; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(_AVRational[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref _AVRational GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public Span<_AVRational> AsSpan() { fixed(void* ptr = &_0) return new Span<_AVRational>(ptr, 3); }
    public ReadOnlySpan<_AVRational> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<_AVRational>(ptr, 3); }
    public static implicit operator Span<_AVRational>(_AVRational3 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<_AVRational>(_AVRational3 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 3) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 3) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct _AVRational3x2 : IFixedArray<_AVRational2>
{
    public static readonly int ArrayLength = 3;
    public readonly int Length => 3;
    #pragma warning disable CS9084
    _AVRational2 _0,_1,_2;
    
    public ref _AVRational2 this[int i] 
    {
        get { CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public ref _AVRational2 this[uint i] 
    {
        get {  CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public _AVRational2[] ToArray()
    {
        var a = new _AVRational2[3];
        for (int i = 0; i < 3; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(_AVRational2[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref _AVRational2 GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public Span<_AVRational2> AsSpan() { fixed(void* ptr = &_0) return new Span<_AVRational2>(ptr, 3); }
    public ReadOnlySpan<_AVRational2> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<_AVRational2>(ptr, 3); }
    public static implicit operator Span<_AVRational2>(_AVRational3x2 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<_AVRational2>(_AVRational3x2 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 3) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 3) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct short3x2 : IFixedArray<short2>
{
    public static readonly int ArrayLength = 3;
    public readonly int Length => 3;
    #pragma warning disable CS9084
    short2 _0,_1,_2;
    
    public ref short2 this[int i] 
    {
        get { CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public ref short2 this[uint i] 
    {
        get {  CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public short2[] ToArray()
    {
        var a = new short2[3];
        for (int i = 0; i < 3; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(short2[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref short2 GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public Span<short2> AsSpan() { fixed(void* ptr = &_0) return new Span<short2>(ptr, 3); }
    public ReadOnlySpan<short2> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<short2>(ptr, 3); }
    public static implicit operator Span<short2>(short3x2 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<short2>(short3x2 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 3) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 3) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct _AVComponentDescriptor4 : IFixedArray<_AVComponentDescriptor>
{
    public static readonly int ArrayLength = 4;
    public readonly int Length => 4;
    #pragma warning disable CS9084
    _AVComponentDescriptor _0,_1,_2,_3;
    
    public ref _AVComponentDescriptor this[int i] 
    {
        get { CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public ref _AVComponentDescriptor this[uint i] 
    {
        get {  CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public _AVComponentDescriptor[] ToArray()
    {
        var a = new _AVComponentDescriptor[4];
        for (int i = 0; i < 4; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(_AVComponentDescriptor[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref _AVComponentDescriptor GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public Span<_AVComponentDescriptor> AsSpan() { fixed(void* ptr = &_0) return new Span<_AVComponentDescriptor>(ptr, 4); }
    public ReadOnlySpan<_AVComponentDescriptor> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<_AVComponentDescriptor>(ptr, 4); }
    public static implicit operator Span<_AVComponentDescriptor>(_AVComponentDescriptor4 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<_AVComponentDescriptor>(_AVComponentDescriptor4 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 4) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 4) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct byte_ptr4 : IFixedPtrArray<byte>
{
    public static readonly int ArrayLength = 4;
    public readonly int Length => 4;
    #pragma warning disable CS9084
    
     void* IFixedPtrArray.this[int i] 
    {
        readonly get { CheckIndex(i); fixed(void* ptr = &_0) return *((void**)ptr + i); }
        set { CheckIndex(i); fixed(void* ptr = &_0) *((void**)ptr + i) = value; }
    }
     void* IFixedPtrArray.this[uint i] 
    {
        readonly get { CheckIndex(i); fixed(void* ptr = &_0) return *((void**)ptr + i); }
        set { CheckIndex(i); fixed(void* ptr = &_0) *((void**)ptr + i) = value; }
    }
     readonly void*[] IFixedPtrArray.ToArray()
    {
        var a = new void*[4];
        for (int i = 0; i < 4; i++) a[i] = this[i];
        return a;
    }
     void IFixedPtrArray.UpdateFrom(void*[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) ((IFixedPtrArray)this)[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    ref void* IFixedPtrArray.GetPinnableReference() => throw new InvalidOperationException("This method should not be called with boxed type.");
    public Span<IntPtr> AsSpan() { fixed(void* ptr = &_0) return new Span<IntPtr>(ptr, 4); }
    public ReadOnlySpan<IntPtr> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<IntPtr>(ptr, 4); }
    #pragma warning restore CS9084
    #pragma warning disable CS9084
    byte* _0,_1,_2,_3;
    
    public byte* this[int i] 
    {
        readonly get { CheckIndex(i); fixed(byte** ptr = &_0) return *(ptr + i); }
        set { CheckIndex(i); fixed(byte** ptr = &_0) *(ptr + i) = value; }
    }
    public byte* this[uint i] 
    {
        readonly get { CheckIndex(i); fixed(byte** ptr = &_0) return *(ptr + i); }
        set { CheckIndex(i); fixed(byte** ptr = &_0) *(ptr + i) = value; }
    }
    public readonly byte*[] ToArray()
    {
        var a = new byte*[4];
        for (int i = 0; i < 4; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(byte*[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    public ref byte* GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public static implicit operator Span<IntPtr>(byte_ptr4 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<IntPtr>(byte_ptr4 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 4) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 4) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct byte4 : IFixedArray<byte>
{
    public static readonly int ArrayLength = 4;
    public readonly int Length => 4;
    fixed byte _[4];
    
    public ref byte this[int i] => ref _[i];
    public ref byte this[uint i] => ref _[(int)i];
    public byte[] ToArray()
    {
        var a = new byte[4]; for (int i = 0; i < 4; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(byte[] array)
    {
        int length = Math.Min(array.Length, 4);
        for(int i = 0; i < length; i++) _[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref byte GetPinnableReference() => ref _[0];
    public Span<byte> AsSpan() { fixed(void* ptr = _) return new Span<byte>(ptr, 4); }
    public ReadOnlySpan<byte> AsReadOnlySpan() { fixed(void* ptr = _) return new ReadOnlySpan<byte>(ptr, 4); }
    public static implicit operator Span<byte>(byte4 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<byte>(byte4 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 4) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 4) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct byte4x6 : IFixedArray<byte6>
{
    public static readonly int ArrayLength = 4;
    public readonly int Length => 4;
    #pragma warning disable CS9084
    byte6 _0,_1,_2,_3;
    
    public ref byte6 this[int i] 
    {
        get { CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public ref byte6 this[uint i] 
    {
        get {  CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public byte6[] ToArray()
    {
        var a = new byte6[4];
        for (int i = 0; i < 4; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(byte6[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref byte6 GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public Span<byte6> AsSpan() { fixed(void* ptr = &_0) return new Span<byte6>(ptr, 4); }
    public ReadOnlySpan<byte6> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<byte6>(ptr, 4); }
    public static implicit operator Span<byte6>(byte4x6 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<byte6>(byte4x6 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 4) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 4) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct int4 : IFixedArray<int>
{
    public static readonly int ArrayLength = 4;
    public readonly int Length => 4;
    fixed int _[4];
    
    public ref int this[int i] => ref _[i];
    public ref int this[uint i] => ref _[(int)i];
    public int[] ToArray()
    {
        var a = new int[4]; for (int i = 0; i < 4; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(int[] array)
    {
        int length = Math.Min(array.Length, 4);
        for(int i = 0; i < length; i++) _[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref int GetPinnableReference() => ref _[0];
    public Span<int> AsSpan() { fixed(void* ptr = _) return new Span<int>(ptr, 4); }
    public ReadOnlySpan<int> AsReadOnlySpan() { fixed(void* ptr = _) return new ReadOnlySpan<int>(ptr, 4); }
    public static implicit operator Span<int>(int4 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<int>(int4 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 4) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 4) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct long4 : IFixedArray<long>
{
    public static readonly int ArrayLength = 4;
    public readonly int Length => 4;
    fixed long _[4];
    
    public ref long this[int i] => ref _[i];
    public ref long this[uint i] => ref _[(int)i];
    public long[] ToArray()
    {
        var a = new long[4]; for (int i = 0; i < 4; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(long[] array)
    {
        int length = Math.Min(array.Length, 4);
        for(int i = 0; i < length; i++) _[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref long GetPinnableReference() => ref _[0];
    public Span<long> AsSpan() { fixed(void* ptr = _) return new Span<long>(ptr, 4); }
    public ReadOnlySpan<long> AsReadOnlySpan() { fixed(void* ptr = _) return new ReadOnlySpan<long>(ptr, 4); }
    public static implicit operator Span<long>(long4 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<long>(long4 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 4) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 4) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct uint4 : IFixedArray<uint>
{
    public static readonly int ArrayLength = 4;
    public readonly int Length => 4;
    fixed uint _[4];
    
    public ref uint this[int i] => ref _[i];
    public ref uint this[uint i] => ref _[(int)i];
    public uint[] ToArray()
    {
        var a = new uint[4]; for (int i = 0; i < 4; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(uint[] array)
    {
        int length = Math.Min(array.Length, 4);
        for(int i = 0; i < length; i++) _[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref uint GetPinnableReference() => ref _[0];
    public Span<uint> AsSpan() { fixed(void* ptr = _) return new Span<uint>(ptr, 4); }
    public ReadOnlySpan<uint> AsReadOnlySpan() { fixed(void* ptr = _) return new ReadOnlySpan<uint>(ptr, 4); }
    public static implicit operator Span<uint>(uint4 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<uint>(uint4 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 4) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 4) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct ulong4 : IFixedArray<ulong>
{
    public static readonly int ArrayLength = 4;
    public readonly int Length => 4;
    fixed ulong _[4];
    
    public ref ulong this[int i] => ref _[i];
    public ref ulong this[uint i] => ref _[(int)i];
    public ulong[] ToArray()
    {
        var a = new ulong[4]; for (int i = 0; i < 4; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(ulong[] array)
    {
        int length = Math.Min(array.Length, 4);
        for(int i = 0; i < length; i++) _[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref ulong GetPinnableReference() => ref _[0];
    public Span<ulong> AsSpan() { fixed(void* ptr = _) return new Span<ulong>(ptr, 4); }
    public ReadOnlySpan<ulong> AsReadOnlySpan() { fixed(void* ptr = _) return new ReadOnlySpan<ulong>(ptr, 4); }
    public static implicit operator Span<ulong>(ulong4 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<ulong>(ulong4 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 4) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 4) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct ushort4 : IFixedArray<ushort>
{
    public static readonly int ArrayLength = 4;
    public readonly int Length => 4;
    fixed ushort _[4];
    
    public ref ushort this[int i] => ref _[i];
    public ref ushort this[uint i] => ref _[(int)i];
    public ushort[] ToArray()
    {
        var a = new ushort[4]; for (int i = 0; i < 4; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(ushort[] array)
    {
        int length = Math.Min(array.Length, 4);
        for(int i = 0; i < length; i++) _[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref ushort GetPinnableReference() => ref _[0];
    public Span<ushort> AsSpan() { fixed(void* ptr = _) return new Span<ushort>(ptr, 4); }
    public ReadOnlySpan<ushort> AsReadOnlySpan() { fixed(void* ptr = _) return new ReadOnlySpan<ushort>(ptr, 4); }
    public static implicit operator Span<ushort>(ushort4 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<ushort>(ushort4 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 4) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 4) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct ushort4x32 : IFixedArray<ushort32>
{
    public static readonly int ArrayLength = 4;
    public readonly int Length => 4;
    #pragma warning disable CS9084
    ushort32 _0,_1,_2,_3;
    
    public ref ushort32 this[int i] 
    {
        get { CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public ref ushort32 this[uint i] 
    {
        get {  CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public ushort32[] ToArray()
    {
        var a = new ushort32[4];
        for (int i = 0; i < 4; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(ushort32[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref ushort32 GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public Span<ushort32> AsSpan() { fixed(void* ptr = &_0) return new Span<ushort32>(ptr, 4); }
    public ReadOnlySpan<ushort32> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<ushort32>(ptr, 4); }
    public static implicit operator Span<ushort32>(ushort4x32 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<ushort32>(ushort4x32 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 4) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 4) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct ushort4x6 : IFixedArray<ushort6>
{
    public static readonly int ArrayLength = 4;
    public readonly int Length => 4;
    #pragma warning disable CS9084
    ushort6 _0,_1,_2,_3;
    
    public ref ushort6 this[int i] 
    {
        get { CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public ref ushort6 this[uint i] 
    {
        get {  CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public ushort6[] ToArray()
    {
        var a = new ushort6[4];
        for (int i = 0; i < 4; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(ushort6[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref ushort6 GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public Span<ushort6> AsSpan() { fixed(void* ptr = &_0) return new Span<ushort6>(ptr, 4); }
    public ReadOnlySpan<ushort6> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<ushort6>(ptr, 4); }
    public static implicit operator Span<ushort6>(ushort4x6 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<ushort6>(ushort4x6 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 4) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 4) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct byte6 : IFixedArray<byte>
{
    public static readonly int ArrayLength = 6;
    public readonly int Length => 6;
    fixed byte _[6];
    
    public ref byte this[int i] => ref _[i];
    public ref byte this[uint i] => ref _[(int)i];
    public byte[] ToArray()
    {
        var a = new byte[6]; for (int i = 0; i < 6; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(byte[] array)
    {
        int length = Math.Min(array.Length, 6);
        for(int i = 0; i < length; i++) _[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref byte GetPinnableReference() => ref _[0];
    public Span<byte> AsSpan() { fixed(void* ptr = _) return new Span<byte>(ptr, 6); }
    public ReadOnlySpan<byte> AsReadOnlySpan() { fixed(void* ptr = _) return new ReadOnlySpan<byte>(ptr, 6); }
    public static implicit operator Span<byte>(byte6 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<byte>(byte6 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 6) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 6) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct ushort6 : IFixedArray<ushort>
{
    public static readonly int ArrayLength = 6;
    public readonly int Length => 6;
    fixed ushort _[6];
    
    public ref ushort this[int i] => ref _[i];
    public ref ushort this[uint i] => ref _[(int)i];
    public ushort[] ToArray()
    {
        var a = new ushort[6]; for (int i = 0; i < 6; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(ushort[] array)
    {
        int length = Math.Min(array.Length, 6);
        for(int i = 0; i < length; i++) _[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref ushort GetPinnableReference() => ref _[0];
    public Span<ushort> AsSpan() { fixed(void* ptr = _) return new Span<ushort>(ptr, 6); }
    public ReadOnlySpan<ushort> AsReadOnlySpan() { fixed(void* ptr = _) return new ReadOnlySpan<ushort>(ptr, 6); }
    public static implicit operator Span<ushort>(ushort6 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<ushort>(ushort6 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 6) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 6) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct _AVCodecID7 : IFixedArray<_AVCodecID>
{
    public static readonly int ArrayLength = 7;
    public readonly int Length => 7;
    #pragma warning disable CS9084
    _AVCodecID _0,_1,_2,_3,_4,_5,_6;
    
    public ref _AVCodecID this[int i] 
    {
        get { CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public ref _AVCodecID this[uint i] 
    {
        get {  CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public _AVCodecID[] ToArray()
    {
        var a = new _AVCodecID[7];
        for (int i = 0; i < 7; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(_AVCodecID[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref _AVCodecID GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public Span<_AVCodecID> AsSpan() { fixed(void* ptr = &_0) return new Span<_AVCodecID>(ptr, 7); }
    public ReadOnlySpan<_AVCodecID> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<_AVCodecID>(ptr, 7); }
    public static implicit operator Span<_AVCodecID>(_AVCodecID7 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<_AVCodecID>(_AVCodecID7 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 7) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 7) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct __cl_mem_ptr8 : IFixedPtrArray<__cl_mem>
{
    public static readonly int ArrayLength = 8;
    public readonly int Length => 8;
    #pragma warning disable CS9084
    
     void* IFixedPtrArray.this[int i] 
    {
        readonly get { CheckIndex(i); fixed(void* ptr = &_0) return *((void**)ptr + i); }
        set { CheckIndex(i); fixed(void* ptr = &_0) *((void**)ptr + i) = value; }
    }
     void* IFixedPtrArray.this[uint i] 
    {
        readonly get { CheckIndex(i); fixed(void* ptr = &_0) return *((void**)ptr + i); }
        set { CheckIndex(i); fixed(void* ptr = &_0) *((void**)ptr + i) = value; }
    }
     readonly void*[] IFixedPtrArray.ToArray()
    {
        var a = new void*[8];
        for (int i = 0; i < 8; i++) a[i] = this[i];
        return a;
    }
     void IFixedPtrArray.UpdateFrom(void*[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) ((IFixedPtrArray)this)[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    ref void* IFixedPtrArray.GetPinnableReference() => throw new InvalidOperationException("This method should not be called with boxed type.");
    public Span<IntPtr> AsSpan() { fixed(void* ptr = &_0) return new Span<IntPtr>(ptr, 8); }
    public ReadOnlySpan<IntPtr> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<IntPtr>(ptr, 8); }
    #pragma warning restore CS9084
    #pragma warning disable CS9084
    __cl_mem* _0,_1,_2,_3,_4,_5,_6,_7;
    
    public __cl_mem* this[int i] 
    {
        readonly get { CheckIndex(i); fixed(__cl_mem** ptr = &_0) return *(ptr + i); }
        set { CheckIndex(i); fixed(__cl_mem** ptr = &_0) *(ptr + i) = value; }
    }
    public __cl_mem* this[uint i] 
    {
        readonly get { CheckIndex(i); fixed(__cl_mem** ptr = &_0) return *(ptr + i); }
        set { CheckIndex(i); fixed(__cl_mem** ptr = &_0) *(ptr + i) = value; }
    }
    public readonly __cl_mem*[] ToArray()
    {
        var a = new __cl_mem*[8];
        for (int i = 0; i < 8; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(__cl_mem*[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    public ref __cl_mem* GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public static implicit operator Span<IntPtr>(__cl_mem_ptr8 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<IntPtr>(__cl_mem_ptr8 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 8) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 8) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct _AVBufferRef_ptr8 : IFixedPtrArray<_AVBufferRef>
{
    public static readonly int ArrayLength = 8;
    public readonly int Length => 8;
    #pragma warning disable CS9084
    
     void* IFixedPtrArray.this[int i] 
    {
        readonly get { CheckIndex(i); fixed(void* ptr = &_0) return *((void**)ptr + i); }
        set { CheckIndex(i); fixed(void* ptr = &_0) *((void**)ptr + i) = value; }
    }
     void* IFixedPtrArray.this[uint i] 
    {
        readonly get { CheckIndex(i); fixed(void* ptr = &_0) return *((void**)ptr + i); }
        set { CheckIndex(i); fixed(void* ptr = &_0) *((void**)ptr + i) = value; }
    }
     readonly void*[] IFixedPtrArray.ToArray()
    {
        var a = new void*[8];
        for (int i = 0; i < 8; i++) a[i] = this[i];
        return a;
    }
     void IFixedPtrArray.UpdateFrom(void*[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) ((IFixedPtrArray)this)[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    ref void* IFixedPtrArray.GetPinnableReference() => throw new InvalidOperationException("This method should not be called with boxed type.");
    public Span<IntPtr> AsSpan() { fixed(void* ptr = &_0) return new Span<IntPtr>(ptr, 8); }
    public ReadOnlySpan<IntPtr> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<IntPtr>(ptr, 8); }
    #pragma warning restore CS9084
    #pragma warning disable CS9084
    _AVBufferRef* _0,_1,_2,_3,_4,_5,_6,_7;
    
    public _AVBufferRef* this[int i] 
    {
        readonly get { CheckIndex(i); fixed(_AVBufferRef** ptr = &_0) return *(ptr + i); }
        set { CheckIndex(i); fixed(_AVBufferRef** ptr = &_0) *(ptr + i) = value; }
    }
    public _AVBufferRef* this[uint i] 
    {
        readonly get { CheckIndex(i); fixed(_AVBufferRef** ptr = &_0) return *(ptr + i); }
        set { CheckIndex(i); fixed(_AVBufferRef** ptr = &_0) *(ptr + i) = value; }
    }
    public readonly _AVBufferRef*[] ToArray()
    {
        var a = new _AVBufferRef*[8];
        for (int i = 0; i < 8; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(_AVBufferRef*[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    public ref _AVBufferRef* GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public static implicit operator Span<IntPtr>(_AVBufferRef_ptr8 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<IntPtr>(_AVBufferRef_ptr8 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 8) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 8) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct _VkDeviceMemory_T_ptr8 : IFixedPtrArray<_VkDeviceMemory_T>
{
    public static readonly int ArrayLength = 8;
    public readonly int Length => 8;
    #pragma warning disable CS9084
    
     void* IFixedPtrArray.this[int i] 
    {
        readonly get { CheckIndex(i); fixed(void* ptr = &_0) return *((void**)ptr + i); }
        set { CheckIndex(i); fixed(void* ptr = &_0) *((void**)ptr + i) = value; }
    }
     void* IFixedPtrArray.this[uint i] 
    {
        readonly get { CheckIndex(i); fixed(void* ptr = &_0) return *((void**)ptr + i); }
        set { CheckIndex(i); fixed(void* ptr = &_0) *((void**)ptr + i) = value; }
    }
     readonly void*[] IFixedPtrArray.ToArray()
    {
        var a = new void*[8];
        for (int i = 0; i < 8; i++) a[i] = this[i];
        return a;
    }
     void IFixedPtrArray.UpdateFrom(void*[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) ((IFixedPtrArray)this)[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    ref void* IFixedPtrArray.GetPinnableReference() => throw new InvalidOperationException("This method should not be called with boxed type.");
    public Span<IntPtr> AsSpan() { fixed(void* ptr = &_0) return new Span<IntPtr>(ptr, 8); }
    public ReadOnlySpan<IntPtr> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<IntPtr>(ptr, 8); }
    #pragma warning restore CS9084
    #pragma warning disable CS9084
    _VkDeviceMemory_T* _0,_1,_2,_3,_4,_5,_6,_7;
    
    public _VkDeviceMemory_T* this[int i] 
    {
        readonly get { CheckIndex(i); fixed(_VkDeviceMemory_T** ptr = &_0) return *(ptr + i); }
        set { CheckIndex(i); fixed(_VkDeviceMemory_T** ptr = &_0) *(ptr + i) = value; }
    }
    public _VkDeviceMemory_T* this[uint i] 
    {
        readonly get { CheckIndex(i); fixed(_VkDeviceMemory_T** ptr = &_0) return *(ptr + i); }
        set { CheckIndex(i); fixed(_VkDeviceMemory_T** ptr = &_0) *(ptr + i) = value; }
    }
    public readonly _VkDeviceMemory_T*[] ToArray()
    {
        var a = new _VkDeviceMemory_T*[8];
        for (int i = 0; i < 8; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(_VkDeviceMemory_T*[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    public ref _VkDeviceMemory_T* GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public static implicit operator Span<IntPtr>(_VkDeviceMemory_T_ptr8 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<IntPtr>(_VkDeviceMemory_T_ptr8 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 8) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 8) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct _VkFormat8 : IFixedArray<_VkFormat>
{
    public static readonly int ArrayLength = 8;
    public readonly int Length => 8;
    #pragma warning disable CS9084
    _VkFormat _0,_1,_2,_3,_4,_5,_6,_7;
    
    public ref _VkFormat this[int i] 
    {
        get { CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public ref _VkFormat this[uint i] 
    {
        get {  CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public _VkFormat[] ToArray()
    {
        var a = new _VkFormat[8];
        for (int i = 0; i < 8; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(_VkFormat[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref _VkFormat GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public Span<_VkFormat> AsSpan() { fixed(void* ptr = &_0) return new Span<_VkFormat>(ptr, 8); }
    public ReadOnlySpan<_VkFormat> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<_VkFormat>(ptr, 8); }
    public static implicit operator Span<_VkFormat>(_VkFormat8 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<_VkFormat>(_VkFormat8 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 8) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 8) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct _VkImage_T_ptr8 : IFixedPtrArray<_VkImage_T>
{
    public static readonly int ArrayLength = 8;
    public readonly int Length => 8;
    #pragma warning disable CS9084
    
     void* IFixedPtrArray.this[int i] 
    {
        readonly get { CheckIndex(i); fixed(void* ptr = &_0) return *((void**)ptr + i); }
        set { CheckIndex(i); fixed(void* ptr = &_0) *((void**)ptr + i) = value; }
    }
     void* IFixedPtrArray.this[uint i] 
    {
        readonly get { CheckIndex(i); fixed(void* ptr = &_0) return *((void**)ptr + i); }
        set { CheckIndex(i); fixed(void* ptr = &_0) *((void**)ptr + i) = value; }
    }
     readonly void*[] IFixedPtrArray.ToArray()
    {
        var a = new void*[8];
        for (int i = 0; i < 8; i++) a[i] = this[i];
        return a;
    }
     void IFixedPtrArray.UpdateFrom(void*[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) ((IFixedPtrArray)this)[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    ref void* IFixedPtrArray.GetPinnableReference() => throw new InvalidOperationException("This method should not be called with boxed type.");
    public Span<IntPtr> AsSpan() { fixed(void* ptr = &_0) return new Span<IntPtr>(ptr, 8); }
    public ReadOnlySpan<IntPtr> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<IntPtr>(ptr, 8); }
    #pragma warning restore CS9084
    #pragma warning disable CS9084
    _VkImage_T* _0,_1,_2,_3,_4,_5,_6,_7;
    
    public _VkImage_T* this[int i] 
    {
        readonly get { CheckIndex(i); fixed(_VkImage_T** ptr = &_0) return *(ptr + i); }
        set { CheckIndex(i); fixed(_VkImage_T** ptr = &_0) *(ptr + i) = value; }
    }
    public _VkImage_T* this[uint i] 
    {
        readonly get { CheckIndex(i); fixed(_VkImage_T** ptr = &_0) return *(ptr + i); }
        set { CheckIndex(i); fixed(_VkImage_T** ptr = &_0) *(ptr + i) = value; }
    }
    public readonly _VkImage_T*[] ToArray()
    {
        var a = new _VkImage_T*[8];
        for (int i = 0; i < 8; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(_VkImage_T*[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    public ref _VkImage_T* GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public static implicit operator Span<IntPtr>(_VkImage_T_ptr8 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<IntPtr>(_VkImage_T_ptr8 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 8) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 8) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct _VkImageLayout8 : IFixedArray<_VkImageLayout>
{
    public static readonly int ArrayLength = 8;
    public readonly int Length => 8;
    #pragma warning disable CS9084
    _VkImageLayout _0,_1,_2,_3,_4,_5,_6,_7;
    
    public ref _VkImageLayout this[int i] 
    {
        get { CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public ref _VkImageLayout this[uint i] 
    {
        get {  CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public _VkImageLayout[] ToArray()
    {
        var a = new _VkImageLayout[8];
        for (int i = 0; i < 8; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(_VkImageLayout[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref _VkImageLayout GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public Span<_VkImageLayout> AsSpan() { fixed(void* ptr = &_0) return new Span<_VkImageLayout>(ptr, 8); }
    public ReadOnlySpan<_VkImageLayout> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<_VkImageLayout>(ptr, 8); }
    public static implicit operator Span<_VkImageLayout>(_VkImageLayout8 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<_VkImageLayout>(_VkImageLayout8 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 8) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 8) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct _VkSemaphore_T_ptr8 : IFixedPtrArray<_VkSemaphore_T>
{
    public static readonly int ArrayLength = 8;
    public readonly int Length => 8;
    #pragma warning disable CS9084
    
     void* IFixedPtrArray.this[int i] 
    {
        readonly get { CheckIndex(i); fixed(void* ptr = &_0) return *((void**)ptr + i); }
        set { CheckIndex(i); fixed(void* ptr = &_0) *((void**)ptr + i) = value; }
    }
     void* IFixedPtrArray.this[uint i] 
    {
        readonly get { CheckIndex(i); fixed(void* ptr = &_0) return *((void**)ptr + i); }
        set { CheckIndex(i); fixed(void* ptr = &_0) *((void**)ptr + i) = value; }
    }
     readonly void*[] IFixedPtrArray.ToArray()
    {
        var a = new void*[8];
        for (int i = 0; i < 8; i++) a[i] = this[i];
        return a;
    }
     void IFixedPtrArray.UpdateFrom(void*[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) ((IFixedPtrArray)this)[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    ref void* IFixedPtrArray.GetPinnableReference() => throw new InvalidOperationException("This method should not be called with boxed type.");
    public Span<IntPtr> AsSpan() { fixed(void* ptr = &_0) return new Span<IntPtr>(ptr, 8); }
    public ReadOnlySpan<IntPtr> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<IntPtr>(ptr, 8); }
    #pragma warning restore CS9084
    #pragma warning disable CS9084
    _VkSemaphore_T* _0,_1,_2,_3,_4,_5,_6,_7;
    
    public _VkSemaphore_T* this[int i] 
    {
        readonly get { CheckIndex(i); fixed(_VkSemaphore_T** ptr = &_0) return *(ptr + i); }
        set { CheckIndex(i); fixed(_VkSemaphore_T** ptr = &_0) *(ptr + i) = value; }
    }
    public _VkSemaphore_T* this[uint i] 
    {
        readonly get { CheckIndex(i); fixed(_VkSemaphore_T** ptr = &_0) return *(ptr + i); }
        set { CheckIndex(i); fixed(_VkSemaphore_T** ptr = &_0) *(ptr + i) = value; }
    }
    public readonly _VkSemaphore_T*[] ToArray()
    {
        var a = new _VkSemaphore_T*[8];
        for (int i = 0; i < 8; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(_VkSemaphore_T*[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    public ref _VkSemaphore_T* GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public static implicit operator Span<IntPtr>(_VkSemaphore_T_ptr8 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<IntPtr>(_VkSemaphore_T_ptr8 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 8) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 8) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct byte_ptr8 : IFixedPtrArray<byte>
{
    public static readonly int ArrayLength = 8;
    public readonly int Length => 8;
    #pragma warning disable CS9084
    
     void* IFixedPtrArray.this[int i] 
    {
        readonly get { CheckIndex(i); fixed(void* ptr = &_0) return *((void**)ptr + i); }
        set { CheckIndex(i); fixed(void* ptr = &_0) *((void**)ptr + i) = value; }
    }
     void* IFixedPtrArray.this[uint i] 
    {
        readonly get { CheckIndex(i); fixed(void* ptr = &_0) return *((void**)ptr + i); }
        set { CheckIndex(i); fixed(void* ptr = &_0) *((void**)ptr + i) = value; }
    }
     readonly void*[] IFixedPtrArray.ToArray()
    {
        var a = new void*[8];
        for (int i = 0; i < 8; i++) a[i] = this[i];
        return a;
    }
     void IFixedPtrArray.UpdateFrom(void*[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) ((IFixedPtrArray)this)[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    ref void* IFixedPtrArray.GetPinnableReference() => throw new InvalidOperationException("This method should not be called with boxed type.");
    public Span<IntPtr> AsSpan() { fixed(void* ptr = &_0) return new Span<IntPtr>(ptr, 8); }
    public ReadOnlySpan<IntPtr> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<IntPtr>(ptr, 8); }
    #pragma warning restore CS9084
    #pragma warning disable CS9084
    byte* _0,_1,_2,_3,_4,_5,_6,_7;
    
    public byte* this[int i] 
    {
        readonly get { CheckIndex(i); fixed(byte** ptr = &_0) return *(ptr + i); }
        set { CheckIndex(i); fixed(byte** ptr = &_0) *(ptr + i) = value; }
    }
    public byte* this[uint i] 
    {
        readonly get { CheckIndex(i); fixed(byte** ptr = &_0) return *(ptr + i); }
        set { CheckIndex(i); fixed(byte** ptr = &_0) *(ptr + i) = value; }
    }
    public readonly byte*[] ToArray()
    {
        var a = new byte*[8];
        for (int i = 0; i < 8; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(byte*[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    public ref byte* GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public static implicit operator Span<IntPtr>(byte_ptr8 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<IntPtr>(byte_ptr8 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 8) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 8) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct byte8 : IFixedArray<byte>
{
    public static readonly int ArrayLength = 8;
    public readonly int Length => 8;
    fixed byte _[8];
    
    public ref byte this[int i] => ref _[i];
    public ref byte this[uint i] => ref _[(int)i];
    public byte[] ToArray()
    {
        var a = new byte[8]; for (int i = 0; i < 8; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(byte[] array)
    {
        int length = Math.Min(array.Length, 8);
        for(int i = 0; i < length; i++) _[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref byte GetPinnableReference() => ref _[0];
    public Span<byte> AsSpan() { fixed(void* ptr = _) return new Span<byte>(ptr, 8); }
    public ReadOnlySpan<byte> AsReadOnlySpan() { fixed(void* ptr = _) return new ReadOnlySpan<byte>(ptr, 8); }
    public static implicit operator Span<byte>(byte8 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<byte>(byte8 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 8) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 8) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct int8 : IFixedArray<int>
{
    public static readonly int ArrayLength = 8;
    public readonly int Length => 8;
    fixed int _[8];
    
    public ref int this[int i] => ref _[i];
    public ref int this[uint i] => ref _[(int)i];
    public int[] ToArray()
    {
        var a = new int[8]; for (int i = 0; i < 8; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(int[] array)
    {
        int length = Math.Min(array.Length, 8);
        for(int i = 0; i < length; i++) _[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref int GetPinnableReference() => ref _[0];
    public Span<int> AsSpan() { fixed(void* ptr = _) return new Span<int>(ptr, 8); }
    public ReadOnlySpan<int> AsReadOnlySpan() { fixed(void* ptr = _) return new ReadOnlySpan<int>(ptr, 8); }
    public static implicit operator Span<int>(int8 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<int>(int8 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 8) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 8) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct long8 : IFixedArray<long>
{
    public static readonly int ArrayLength = 8;
    public readonly int Length => 8;
    fixed long _[8];
    
    public ref long this[int i] => ref _[i];
    public ref long this[uint i] => ref _[(int)i];
    public long[] ToArray()
    {
        var a = new long[8]; for (int i = 0; i < 8; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(long[] array)
    {
        int length = Math.Min(array.Length, 8);
        for(int i = 0; i < length; i++) _[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref long GetPinnableReference() => ref _[0];
    public Span<long> AsSpan() { fixed(void* ptr = _) return new Span<long>(ptr, 8); }
    public ReadOnlySpan<long> AsReadOnlySpan() { fixed(void* ptr = _) return new ReadOnlySpan<long>(ptr, 8); }
    public static implicit operator Span<long>(long8 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<long>(long8 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 8) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 8) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct uint8 : IFixedArray<uint>
{
    public static readonly int ArrayLength = 8;
    public readonly int Length => 8;
    fixed uint _[8];
    
    public ref uint this[int i] => ref _[i];
    public ref uint this[uint i] => ref _[(int)i];
    public uint[] ToArray()
    {
        var a = new uint[8]; for (int i = 0; i < 8; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(uint[] array)
    {
        int length = Math.Min(array.Length, 8);
        for(int i = 0; i < length; i++) _[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref uint GetPinnableReference() => ref _[0];
    public Span<uint> AsSpan() { fixed(void* ptr = _) return new Span<uint>(ptr, 8); }
    public ReadOnlySpan<uint> AsReadOnlySpan() { fixed(void* ptr = _) return new ReadOnlySpan<uint>(ptr, 8); }
    public static implicit operator Span<uint>(uint8 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<uint>(uint8 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 8) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 8) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct ulong8 : IFixedArray<ulong>
{
    public static readonly int ArrayLength = 8;
    public readonly int Length => 8;
    fixed ulong _[8];
    
    public ref ulong this[int i] => ref _[i];
    public ref ulong this[uint i] => ref _[(int)i];
    public ulong[] ToArray()
    {
        var a = new ulong[8]; for (int i = 0; i < 8; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(ulong[] array)
    {
        int length = Math.Min(array.Length, 8);
        for(int i = 0; i < length; i++) _[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref ulong GetPinnableReference() => ref _[0];
    public Span<ulong> AsSpan() { fixed(void* ptr = _) return new Span<ulong>(ptr, 8); }
    public ReadOnlySpan<ulong> AsReadOnlySpan() { fixed(void* ptr = _) return new ReadOnlySpan<ulong>(ptr, 8); }
    public static implicit operator Span<ulong>(ulong8 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<ulong>(ulong8 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 8) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 8) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct ushort8 : IFixedArray<ushort>
{
    public static readonly int ArrayLength = 8;
    public readonly int Length => 8;
    fixed ushort _[8];
    
    public ref ushort this[int i] => ref _[i];
    public ref ushort this[uint i] => ref _[(int)i];
    public ushort[] ToArray()
    {
        var a = new ushort[8]; for (int i = 0; i < 8; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(ushort[] array)
    {
        int length = Math.Min(array.Length, 8);
        for(int i = 0; i < length; i++) _[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref ushort GetPinnableReference() => ref _[0];
    public Span<ushort> AsSpan() { fixed(void* ptr = _) return new Span<ushort>(ptr, 8); }
    public ReadOnlySpan<ushort> AsReadOnlySpan() { fixed(void* ptr = _) return new ReadOnlySpan<ushort>(ptr, 8); }
    public static implicit operator Span<ushort>(ushort8 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<ushort>(ushort8 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 8) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 8) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct void_ptr8 : IFixedPtrArray
{
    public static readonly int ArrayLength = 8;
    public readonly int Length => 8;
    #pragma warning disable CS9084
    void* _0,_1,_2,_3,_4,_5,_6,_7;
    
    public void* this[int i] 
    {
        readonly get { CheckIndex(i); fixed(void* ptr = &_0) return *((void**)ptr + i); }
        set { CheckIndex(i); fixed(void* ptr = &_0) *((void**)ptr + i) = value; }
    }
    public void* this[uint i] 
    {
        readonly get { CheckIndex(i); fixed(void* ptr = &_0) return *((void**)ptr + i); }
        set { CheckIndex(i); fixed(void* ptr = &_0) *((void**)ptr + i) = value; }
    }
    public readonly void*[] ToArray()
    {
        var a = new void*[8];
        for (int i = 0; i < 8; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(void*[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref void* GetPinnableReference() => ref _0;
    public Span<IntPtr> AsSpan() { fixed(void* ptr = &_0) return new Span<IntPtr>(ptr, 8); }
    public ReadOnlySpan<IntPtr> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<IntPtr>(ptr, 8); }
    #pragma warning restore CS9084
    public static implicit operator Span<IntPtr>(void_ptr8 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<IntPtr>(void_ptr8 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 8) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 8) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct int9 : IFixedArray<int>
{
    public static readonly int ArrayLength = 9;
    public readonly int Length => 9;
    fixed int _[9];
    
    public ref int this[int i] => ref _[i];
    public ref int this[uint i] => ref _[(int)i];
    public int[] ToArray()
    {
        var a = new int[9]; for (int i = 0; i < 9; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(int[] array)
    {
        int length = Math.Min(array.Length, 9);
        for(int i = 0; i < length; i++) _[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref int GetPinnableReference() => ref _[0];
    public Span<int> AsSpan() { fixed(void* ptr = _) return new Span<int>(ptr, 9); }
    public ReadOnlySpan<int> AsReadOnlySpan() { fixed(void* ptr = _) return new ReadOnlySpan<int>(ptr, 9); }
    public static implicit operator Span<int>(int9 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<int>(int9 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 9) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 9) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct _AVHDRPlusPercentile15 : IFixedArray<_AVHDRPlusPercentile>
{
    public static readonly int ArrayLength = 15;
    public readonly int Length => 15;
    #pragma warning disable CS9084
    _AVHDRPlusPercentile _0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14;
    
    public ref _AVHDRPlusPercentile this[int i] 
    {
        get { CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public ref _AVHDRPlusPercentile this[uint i] 
    {
        get {  CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public _AVHDRPlusPercentile[] ToArray()
    {
        var a = new _AVHDRPlusPercentile[15];
        for (int i = 0; i < 15; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(_AVHDRPlusPercentile[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref _AVHDRPlusPercentile GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public Span<_AVHDRPlusPercentile> AsSpan() { fixed(void* ptr = &_0) return new Span<_AVHDRPlusPercentile>(ptr, 15); }
    public ReadOnlySpan<_AVHDRPlusPercentile> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<_AVHDRPlusPercentile>(ptr, 15); }
    public static implicit operator Span<_AVHDRPlusPercentile>(_AVHDRPlusPercentile15 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<_AVHDRPlusPercentile>(_AVHDRPlusPercentile15 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 15) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 15) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct _AVRational15 : IFixedArray<_AVRational>
{
    public static readonly int ArrayLength = 15;
    public readonly int Length => 15;
    #pragma warning disable CS9084
    _AVRational _0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14;
    
    public ref _AVRational this[int i] 
    {
        get { CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public ref _AVRational this[uint i] 
    {
        get {  CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public _AVRational[] ToArray()
    {
        var a = new _AVRational[15];
        for (int i = 0; i < 15; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(_AVRational[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref _AVRational GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public Span<_AVRational> AsSpan() { fixed(void* ptr = &_0) return new Span<_AVRational>(ptr, 15); }
    public ReadOnlySpan<_AVRational> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<_AVRational>(ptr, 15); }
    public static implicit operator Span<_AVRational>(_AVRational15 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<_AVRational>(_AVRational15 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 15) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 15) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct byte16 : IFixedArray<byte>
{
    public static readonly int ArrayLength = 16;
    public readonly int Length => 16;
    fixed byte _[16];
    
    public ref byte this[int i] => ref _[i];
    public ref byte this[uint i] => ref _[(int)i];
    public byte[] ToArray()
    {
        var a = new byte[16]; for (int i = 0; i < 16; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(byte[] array)
    {
        int length = Math.Min(array.Length, 16);
        for(int i = 0; i < length; i++) _[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref byte GetPinnableReference() => ref _[0];
    public Span<byte> AsSpan() { fixed(void* ptr = _) return new Span<byte>(ptr, 16); }
    public ReadOnlySpan<byte> AsReadOnlySpan() { fixed(void* ptr = _) return new ReadOnlySpan<byte>(ptr, 16); }
    public static implicit operator Span<byte>(byte16 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<byte>(byte16 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 16) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 16) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct _AVRational25 : IFixedArray<_AVRational>
{
    public static readonly int ArrayLength = 25;
    public readonly int Length => 25;
    #pragma warning disable CS9084
    _AVRational _0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24;
    
    public ref _AVRational this[int i] 
    {
        get { CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public ref _AVRational this[uint i] 
    {
        get {  CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public _AVRational[] ToArray()
    {
        var a = new _AVRational[25];
        for (int i = 0; i < 25; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(_AVRational[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref _AVRational GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public Span<_AVRational> AsSpan() { fixed(void* ptr = &_0) return new Span<_AVRational>(ptr, 25); }
    public ReadOnlySpan<_AVRational> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<_AVRational>(ptr, 25); }
    public static implicit operator Span<_AVRational>(_AVRational25 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<_AVRational>(_AVRational25 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 25) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 25) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct _AVRational25x25 : IFixedArray<_AVRational25>
{
    public static readonly int ArrayLength = 25;
    public readonly int Length => 25;
    #pragma warning disable CS9084
    _AVRational25 _0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24;
    
    public ref _AVRational25 this[int i] 
    {
        get { CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public ref _AVRational25 this[uint i] 
    {
        get {  CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public _AVRational25[] ToArray()
    {
        var a = new _AVRational25[25];
        for (int i = 0; i < 25; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(_AVRational25[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref _AVRational25 GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public Span<_AVRational25> AsSpan() { fixed(void* ptr = &_0) return new Span<_AVRational25>(ptr, 25); }
    public ReadOnlySpan<_AVRational25> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<_AVRational25>(ptr, 25); }
    public static implicit operator Span<_AVRational25>(_AVRational25x25 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<_AVRational25>(_AVRational25x25 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 25) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 25) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct ushort32 : IFixedArray<ushort>
{
    public static readonly int ArrayLength = 32;
    public readonly int Length => 32;
    fixed ushort _[32];
    
    public ref ushort this[int i] => ref _[i];
    public ref ushort this[uint i] => ref _[(int)i];
    public ushort[] ToArray()
    {
        var a = new ushort[32]; for (int i = 0; i < 32; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(ushort[] array)
    {
        int length = Math.Min(array.Length, 32);
        for(int i = 0; i < length; i++) _[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref ushort GetPinnableReference() => ref _[0];
    public Span<ushort> AsSpan() { fixed(void* ptr = _) return new Span<ushort>(ptr, 32); }
    public ReadOnlySpan<ushort> AsReadOnlySpan() { fixed(void* ptr = _) return new ReadOnlySpan<ushort>(ptr, 32); }
    public static implicit operator Span<ushort>(ushort32 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<ushort>(ushort32 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 32) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 32) throw new ArgumentOutOfRangeException();
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct _AVVulkanDeviceQueueFamily64 : IFixedArray<_AVVulkanDeviceQueueFamily>
{
    public static readonly int ArrayLength = 64;
    public readonly int Length => 64;
    #pragma warning disable CS9084
    _AVVulkanDeviceQueueFamily _0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36,_37,_38,_39,_40,_41,_42,_43,_44,_45,_46,_47,_48,_49,_50,_51,_52,_53,_54,_55,_56,_57,_58,_59,_60,_61,_62,_63;
    
    public ref _AVVulkanDeviceQueueFamily this[int i] 
    {
        get { CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public ref _AVVulkanDeviceQueueFamily this[uint i] 
    {
        get {  CheckIndex(i); return ref Unsafe.Add(ref _0, i); }
    }
    public _AVVulkanDeviceQueueFamily[] ToArray()
    {
        var a = new _AVVulkanDeviceQueueFamily[64];
        for (int i = 0; i < 64; i++) a[i] = this[i];
        return a;
    }
    public void UpdateFrom(_AVVulkanDeviceQueueFamily[] array)
    {
        int length = Math.Min(array.Length, Length);
        for(int i = 0; i < length; i++) this[i] = array[i];
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref _AVVulkanDeviceQueueFamily GetPinnableReference() => ref _0;
    #pragma warning restore CS9084
    public Span<_AVVulkanDeviceQueueFamily> AsSpan() { fixed(void* ptr = &_0) return new Span<_AVVulkanDeviceQueueFamily>(ptr, 64); }
    public ReadOnlySpan<_AVVulkanDeviceQueueFamily> AsReadOnlySpan() { fixed(void* ptr = &_0) return new ReadOnlySpan<_AVVulkanDeviceQueueFamily>(ptr, 64); }
    public static implicit operator Span<_AVVulkanDeviceQueueFamily>(_AVVulkanDeviceQueueFamily64 array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<_AVVulkanDeviceQueueFamily>(_AVVulkanDeviceQueueFamily64 array) => array.AsReadOnlySpan();
    private static void CheckIndex(int index)
    {
        if ((uint)index >= 64) throw new ArgumentOutOfRangeException();
    }
    private static void CheckIndex(uint index)
    {
        if (index >= 64) throw new ArgumentOutOfRangeException();
    }
}

