using System;

namespace FFmpeg.AutoGen.Abstractions;

public unsafe struct _AVRational2 : IFixedArray<_AVRational>
{
    public static readonly int ArrayLength = 2;
    public int Length => 2;
    _AVRational _0; _AVRational _1;
    
    public _AVRational this[uint i]
    {
        get { if (i >= 2) throw new ArgumentOutOfRangeException(); fixed (_AVRational* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 2) throw new ArgumentOutOfRangeException(); fixed (_AVRational* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public _AVRational[] ToArray()
    {
        fixed (_AVRational* p0 = &_0) { var a = new _AVRational[2]; for (uint i = 0; i < 2; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(_AVRational[] array)
    {
        fixed (_AVRational* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 2) return; } }
    }
    public static implicit operator _AVRational[](_AVRational2 @struct) => @struct.ToArray();
}

public unsafe struct double2 : IFixedArray<double>
{
    public static readonly int ArrayLength = 2;
    public int Length => 2;
    fixed double _[2];
    
    public double this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public double[] ToArray()
    {
        var a = new double[2]; for (uint i = 0; i < 2; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(double[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 2) return; }
    }
    public static implicit operator double[](double2 @struct) => @struct.ToArray();
}

public unsafe struct short2 : IFixedArray<short>
{
    public static readonly int ArrayLength = 2;
    public int Length => 2;
    fixed short _[2];
    
    public short this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public short[] ToArray()
    {
        var a = new short[2]; for (uint i = 0; i < 2; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(short[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 2) return; }
    }
    public static implicit operator short[](short2 @struct) => @struct.ToArray();
}

public unsafe struct void_ptr2 : IFixedArray
{
    public static readonly int ArrayLength = 2;
    public int Length => 2;
    void* _0; void* _1;
    
    public void* this[uint i]
    {
        get { if (i >= 2) throw new ArgumentOutOfRangeException(); fixed (void** p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 2) throw new ArgumentOutOfRangeException(); fixed (void** p0 = &_0) { *(p0 + i) = value;  } }
    }
    public void*[] ToArray()
    {
        fixed (void** p0 = &_0) { var a = new void*[2]; for (uint i = 0; i < 2; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(void*[] array)
    {
        fixed (void** p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 2) return; } }
    }
    public static implicit operator void*[](void_ptr2 @struct) => @struct.ToArray();
}

public unsafe struct _AVHDRPlusColorTransformParams3 : IFixedArray<_AVHDRPlusColorTransformParams>
{
    public static readonly int ArrayLength = 3;
    public int Length => 3;
    _AVHDRPlusColorTransformParams _0; _AVHDRPlusColorTransformParams _1; _AVHDRPlusColorTransformParams _2;
    
    public _AVHDRPlusColorTransformParams this[uint i]
    {
        get { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (_AVHDRPlusColorTransformParams* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (_AVHDRPlusColorTransformParams* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public _AVHDRPlusColorTransformParams[] ToArray()
    {
        fixed (_AVHDRPlusColorTransformParams* p0 = &_0) { var a = new _AVHDRPlusColorTransformParams[3]; for (uint i = 0; i < 3; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(_AVHDRPlusColorTransformParams[] array)
    {
        fixed (_AVHDRPlusColorTransformParams* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 3) return; } }
    }
    public static implicit operator _AVHDRPlusColorTransformParams[](_AVHDRPlusColorTransformParams3 @struct) => @struct.ToArray();
}

public unsafe struct _AVRational3 : IFixedArray<_AVRational>
{
    public static readonly int ArrayLength = 3;
    public int Length => 3;
    _AVRational _0; _AVRational _1; _AVRational _2;
    
    public _AVRational this[uint i]
    {
        get { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (_AVRational* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (_AVRational* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public _AVRational[] ToArray()
    {
        fixed (_AVRational* p0 = &_0) { var a = new _AVRational[3]; for (uint i = 0; i < 3; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(_AVRational[] array)
    {
        fixed (_AVRational* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 3) return; } }
    }
    public static implicit operator _AVRational[](_AVRational3 @struct) => @struct.ToArray();
}

public unsafe struct _AVRational3x2 : IFixedArray<_AVRational2>
{
    public static readonly int ArrayLength = 3;
    public int Length => 3;
    _AVRational2 _0; _AVRational2 _1; _AVRational2 _2;
    
    public _AVRational2 this[uint i]
    {
        get { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (_AVRational2* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (_AVRational2* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public _AVRational2[] ToArray()
    {
        fixed (_AVRational2* p0 = &_0) { var a = new _AVRational2[3]; for (uint i = 0; i < 3; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(_AVRational2[] array)
    {
        fixed (_AVRational2* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 3) return; } }
    }
    public static implicit operator _AVRational2[](_AVRational3x2 @struct) => @struct.ToArray();
}

public unsafe struct short3x2 : IFixedArray<short2>
{
    public static readonly int ArrayLength = 3;
    public int Length => 3;
    short2 _0; short2 _1; short2 _2;
    
    public short2 this[uint i]
    {
        get { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (short2* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (short2* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public short2[] ToArray()
    {
        fixed (short2* p0 = &_0) { var a = new short2[3]; for (uint i = 0; i < 3; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(short2[] array)
    {
        fixed (short2* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 3) return; } }
    }
    public static implicit operator short2[](short3x2 @struct) => @struct.ToArray();
}

public unsafe struct _AVComponentDescriptor4 : IFixedArray<_AVComponentDescriptor>
{
    public static readonly int ArrayLength = 4;
    public int Length => 4;
    _AVComponentDescriptor _0; _AVComponentDescriptor _1; _AVComponentDescriptor _2; _AVComponentDescriptor _3;
    
    public _AVComponentDescriptor this[uint i]
    {
        get { if (i >= 4) throw new ArgumentOutOfRangeException(); fixed (_AVComponentDescriptor* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 4) throw new ArgumentOutOfRangeException(); fixed (_AVComponentDescriptor* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public _AVComponentDescriptor[] ToArray()
    {
        fixed (_AVComponentDescriptor* p0 = &_0) { var a = new _AVComponentDescriptor[4]; for (uint i = 0; i < 4; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(_AVComponentDescriptor[] array)
    {
        fixed (_AVComponentDescriptor* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 4) return; } }
    }
    public static implicit operator _AVComponentDescriptor[](_AVComponentDescriptor4 @struct) => @struct.ToArray();
}

public unsafe struct byte_ptr4 : IFixedArray
{
    public static readonly int ArrayLength = 4;
    public int Length => 4;
    byte* _0; byte* _1; byte* _2; byte* _3;
    
    public byte* this[uint i]
    {
        get { if (i >= 4) throw new ArgumentOutOfRangeException(); fixed (byte** p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 4) throw new ArgumentOutOfRangeException(); fixed (byte** p0 = &_0) { *(p0 + i) = value;  } }
    }
    public byte*[] ToArray()
    {
        fixed (byte** p0 = &_0) { var a = new byte*[4]; for (uint i = 0; i < 4; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(byte*[] array)
    {
        fixed (byte** p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 4) return; } }
    }
    public static implicit operator byte*[](byte_ptr4 @struct) => @struct.ToArray();
}

public unsafe struct byte4 : IFixedArray<byte>
{
    public static readonly int ArrayLength = 4;
    public int Length => 4;
    fixed byte _[4];
    
    public byte this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public byte[] ToArray()
    {
        var a = new byte[4]; for (uint i = 0; i < 4; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(byte[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 4) return; }
    }
    public static implicit operator byte[](byte4 @struct) => @struct.ToArray();
}

public unsafe struct byte4x6 : IFixedArray<byte6>
{
    public static readonly int ArrayLength = 4;
    public int Length => 4;
    byte6 _0; byte6 _1; byte6 _2; byte6 _3;
    
    public byte6 this[uint i]
    {
        get { if (i >= 4) throw new ArgumentOutOfRangeException(); fixed (byte6* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 4) throw new ArgumentOutOfRangeException(); fixed (byte6* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public byte6[] ToArray()
    {
        fixed (byte6* p0 = &_0) { var a = new byte6[4]; for (uint i = 0; i < 4; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(byte6[] array)
    {
        fixed (byte6* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 4) return; } }
    }
    public static implicit operator byte6[](byte4x6 @struct) => @struct.ToArray();
}

public unsafe struct int4 : IFixedArray<int>
{
    public static readonly int ArrayLength = 4;
    public int Length => 4;
    fixed int _[4];
    
    public int this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public int[] ToArray()
    {
        var a = new int[4]; for (uint i = 0; i < 4; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(int[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 4) return; }
    }
    public static implicit operator int[](int4 @struct) => @struct.ToArray();
}

public unsafe struct long4 : IFixedArray<long>
{
    public static readonly int ArrayLength = 4;
    public int Length => 4;
    fixed long _[4];
    
    public long this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public long[] ToArray()
    {
        var a = new long[4]; for (uint i = 0; i < 4; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(long[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 4) return; }
    }
    public static implicit operator long[](long4 @struct) => @struct.ToArray();
}

public unsafe struct uint4 : IFixedArray<uint>
{
    public static readonly int ArrayLength = 4;
    public int Length => 4;
    fixed uint _[4];
    
    public uint this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public uint[] ToArray()
    {
        var a = new uint[4]; for (uint i = 0; i < 4; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(uint[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 4) return; }
    }
    public static implicit operator uint[](uint4 @struct) => @struct.ToArray();
}

public unsafe struct ulong4 : IFixedArray<ulong>
{
    public static readonly int ArrayLength = 4;
    public int Length => 4;
    fixed ulong _[4];
    
    public ulong this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public ulong[] ToArray()
    {
        var a = new ulong[4]; for (uint i = 0; i < 4; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(ulong[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 4) return; }
    }
    public static implicit operator ulong[](ulong4 @struct) => @struct.ToArray();
}

public unsafe struct ushort4 : IFixedArray<ushort>
{
    public static readonly int ArrayLength = 4;
    public int Length => 4;
    fixed ushort _[4];
    
    public ushort this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public ushort[] ToArray()
    {
        var a = new ushort[4]; for (uint i = 0; i < 4; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(ushort[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 4) return; }
    }
    public static implicit operator ushort[](ushort4 @struct) => @struct.ToArray();
}

public unsafe struct ushort4x32 : IFixedArray<ushort32>
{
    public static readonly int ArrayLength = 4;
    public int Length => 4;
    ushort32 _0; ushort32 _1; ushort32 _2; ushort32 _3;
    
    public ushort32 this[uint i]
    {
        get { if (i >= 4) throw new ArgumentOutOfRangeException(); fixed (ushort32* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 4) throw new ArgumentOutOfRangeException(); fixed (ushort32* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public ushort32[] ToArray()
    {
        fixed (ushort32* p0 = &_0) { var a = new ushort32[4]; for (uint i = 0; i < 4; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(ushort32[] array)
    {
        fixed (ushort32* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 4) return; } }
    }
    public static implicit operator ushort32[](ushort4x32 @struct) => @struct.ToArray();
}

public unsafe struct ushort4x6 : IFixedArray<ushort6>
{
    public static readonly int ArrayLength = 4;
    public int Length => 4;
    ushort6 _0; ushort6 _1; ushort6 _2; ushort6 _3;
    
    public ushort6 this[uint i]
    {
        get { if (i >= 4) throw new ArgumentOutOfRangeException(); fixed (ushort6* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 4) throw new ArgumentOutOfRangeException(); fixed (ushort6* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public ushort6[] ToArray()
    {
        fixed (ushort6* p0 = &_0) { var a = new ushort6[4]; for (uint i = 0; i < 4; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(ushort6[] array)
    {
        fixed (ushort6* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 4) return; } }
    }
    public static implicit operator ushort6[](ushort4x6 @struct) => @struct.ToArray();
}

public unsafe struct byte6 : IFixedArray<byte>
{
    public static readonly int ArrayLength = 6;
    public int Length => 6;
    fixed byte _[6];
    
    public byte this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public byte[] ToArray()
    {
        var a = new byte[6]; for (uint i = 0; i < 6; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(byte[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 6) return; }
    }
    public static implicit operator byte[](byte6 @struct) => @struct.ToArray();
}

public unsafe struct ushort6 : IFixedArray<ushort>
{
    public static readonly int ArrayLength = 6;
    public int Length => 6;
    fixed ushort _[6];
    
    public ushort this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public ushort[] ToArray()
    {
        var a = new ushort[6]; for (uint i = 0; i < 6; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(ushort[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 6) return; }
    }
    public static implicit operator ushort[](ushort6 @struct) => @struct.ToArray();
}

public unsafe struct _AVCodecID7 : IFixedArray<_AVCodecID>
{
    public static readonly int ArrayLength = 7;
    public int Length => 7;
    _AVCodecID _0; _AVCodecID _1; _AVCodecID _2; _AVCodecID _3; _AVCodecID _4; _AVCodecID _5; _AVCodecID _6;
    
    public _AVCodecID this[uint i]
    {
        get { if (i >= 7) throw new ArgumentOutOfRangeException(); fixed (_AVCodecID* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 7) throw new ArgumentOutOfRangeException(); fixed (_AVCodecID* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public _AVCodecID[] ToArray()
    {
        fixed (_AVCodecID* p0 = &_0) { var a = new _AVCodecID[7]; for (uint i = 0; i < 7; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(_AVCodecID[] array)
    {
        fixed (_AVCodecID* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 7) return; } }
    }
    public static implicit operator _AVCodecID[](_AVCodecID7 @struct) => @struct.ToArray();
}

public unsafe struct _AVBufferRef_ptr8 : IFixedArray
{
    public static readonly int ArrayLength = 8;
    public int Length => 8;
    _AVBufferRef* _0; _AVBufferRef* _1; _AVBufferRef* _2; _AVBufferRef* _3; _AVBufferRef* _4; _AVBufferRef* _5; _AVBufferRef* _6; _AVBufferRef* _7;
    
    public _AVBufferRef* this[uint i]
    {
        get { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (_AVBufferRef** p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (_AVBufferRef** p0 = &_0) { *(p0 + i) = value;  } }
    }
    public _AVBufferRef*[] ToArray()
    {
        fixed (_AVBufferRef** p0 = &_0) { var a = new _AVBufferRef*[8]; for (uint i = 0; i < 8; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(_AVBufferRef*[] array)
    {
        fixed (_AVBufferRef** p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 8) return; } }
    }
    public static implicit operator _AVBufferRef*[](_AVBufferRef_ptr8 @struct) => @struct.ToArray();
}

public unsafe struct byte_ptr8 : IFixedArray
{
    public static readonly int ArrayLength = 8;
    public int Length => 8;
    byte* _0; byte* _1; byte* _2; byte* _3; byte* _4; byte* _5; byte* _6; byte* _7;
    
    public byte* this[uint i]
    {
        get { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (byte** p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (byte** p0 = &_0) { *(p0 + i) = value;  } }
    }
    public byte*[] ToArray()
    {
        fixed (byte** p0 = &_0) { var a = new byte*[8]; for (uint i = 0; i < 8; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(byte*[] array)
    {
        fixed (byte** p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 8) return; } }
    }
    public static implicit operator byte*[](byte_ptr8 @struct) => @struct.ToArray();
}

public unsafe struct byte8 : IFixedArray<byte>
{
    public static readonly int ArrayLength = 8;
    public int Length => 8;
    fixed byte _[8];
    
    public byte this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public byte[] ToArray()
    {
        var a = new byte[8]; for (uint i = 0; i < 8; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(byte[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 8) return; }
    }
    public static implicit operator byte[](byte8 @struct) => @struct.ToArray();
}

public unsafe struct int8 : IFixedArray<int>
{
    public static readonly int ArrayLength = 8;
    public int Length => 8;
    fixed int _[8];
    
    public int this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public int[] ToArray()
    {
        var a = new int[8]; for (uint i = 0; i < 8; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(int[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 8) return; }
    }
    public static implicit operator int[](int8 @struct) => @struct.ToArray();
}

public unsafe struct ulong8 : IFixedArray<ulong>
{
    public static readonly int ArrayLength = 8;
    public int Length => 8;
    fixed ulong _[8];
    
    public ulong this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public ulong[] ToArray()
    {
        var a = new ulong[8]; for (uint i = 0; i < 8; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(ulong[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 8) return; }
    }
    public static implicit operator ulong[](ulong8 @struct) => @struct.ToArray();
}

public unsafe struct ushort8 : IFixedArray<ushort>
{
    public static readonly int ArrayLength = 8;
    public int Length => 8;
    fixed ushort _[8];
    
    public ushort this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public ushort[] ToArray()
    {
        var a = new ushort[8]; for (uint i = 0; i < 8; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(ushort[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 8) return; }
    }
    public static implicit operator ushort[](ushort8 @struct) => @struct.ToArray();
}

public unsafe struct int9 : IFixedArray<int>
{
    public static readonly int ArrayLength = 9;
    public int Length => 9;
    fixed int _[9];
    
    public int this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public int[] ToArray()
    {
        var a = new int[9]; for (uint i = 0; i < 9; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(int[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 9) return; }
    }
    public static implicit operator int[](int9 @struct) => @struct.ToArray();
}

public unsafe struct _AVHDRPlusPercentile15 : IFixedArray<_AVHDRPlusPercentile>
{
    public static readonly int ArrayLength = 15;
    public int Length => 15;
    _AVHDRPlusPercentile _0; _AVHDRPlusPercentile _1; _AVHDRPlusPercentile _2; _AVHDRPlusPercentile _3; _AVHDRPlusPercentile _4; _AVHDRPlusPercentile _5; _AVHDRPlusPercentile _6; _AVHDRPlusPercentile _7; _AVHDRPlusPercentile _8; _AVHDRPlusPercentile _9; _AVHDRPlusPercentile _10; _AVHDRPlusPercentile _11; _AVHDRPlusPercentile _12; _AVHDRPlusPercentile _13; _AVHDRPlusPercentile _14;
    
    public _AVHDRPlusPercentile this[uint i]
    {
        get { if (i >= 15) throw new ArgumentOutOfRangeException(); fixed (_AVHDRPlusPercentile* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 15) throw new ArgumentOutOfRangeException(); fixed (_AVHDRPlusPercentile* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public _AVHDRPlusPercentile[] ToArray()
    {
        fixed (_AVHDRPlusPercentile* p0 = &_0) { var a = new _AVHDRPlusPercentile[15]; for (uint i = 0; i < 15; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(_AVHDRPlusPercentile[] array)
    {
        fixed (_AVHDRPlusPercentile* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 15) return; } }
    }
    public static implicit operator _AVHDRPlusPercentile[](_AVHDRPlusPercentile15 @struct) => @struct.ToArray();
}

public unsafe struct _AVRational15 : IFixedArray<_AVRational>
{
    public static readonly int ArrayLength = 15;
    public int Length => 15;
    _AVRational _0; _AVRational _1; _AVRational _2; _AVRational _3; _AVRational _4; _AVRational _5; _AVRational _6; _AVRational _7; _AVRational _8; _AVRational _9; _AVRational _10; _AVRational _11; _AVRational _12; _AVRational _13; _AVRational _14;
    
    public _AVRational this[uint i]
    {
        get { if (i >= 15) throw new ArgumentOutOfRangeException(); fixed (_AVRational* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 15) throw new ArgumentOutOfRangeException(); fixed (_AVRational* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public _AVRational[] ToArray()
    {
        fixed (_AVRational* p0 = &_0) { var a = new _AVRational[15]; for (uint i = 0; i < 15; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(_AVRational[] array)
    {
        fixed (_AVRational* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 15) return; } }
    }
    public static implicit operator _AVRational[](_AVRational15 @struct) => @struct.ToArray();
}

public unsafe struct byte16 : IFixedArray<byte>
{
    public static readonly int ArrayLength = 16;
    public int Length => 16;
    fixed byte _[16];
    
    public byte this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public byte[] ToArray()
    {
        var a = new byte[16]; for (uint i = 0; i < 16; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(byte[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 16) return; }
    }
    public static implicit operator byte[](byte16 @struct) => @struct.ToArray();
}

public unsafe struct _AVRational25 : IFixedArray<_AVRational>
{
    public static readonly int ArrayLength = 25;
    public int Length => 25;
    _AVRational _0; _AVRational _1; _AVRational _2; _AVRational _3; _AVRational _4; _AVRational _5; _AVRational _6; _AVRational _7; _AVRational _8; _AVRational _9; _AVRational _10; _AVRational _11; _AVRational _12; _AVRational _13; _AVRational _14; _AVRational _15; _AVRational _16; _AVRational _17; _AVRational _18; _AVRational _19; _AVRational _20; _AVRational _21; _AVRational _22; _AVRational _23; _AVRational _24;
    
    public _AVRational this[uint i]
    {
        get { if (i >= 25) throw new ArgumentOutOfRangeException(); fixed (_AVRational* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 25) throw new ArgumentOutOfRangeException(); fixed (_AVRational* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public _AVRational[] ToArray()
    {
        fixed (_AVRational* p0 = &_0) { var a = new _AVRational[25]; for (uint i = 0; i < 25; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(_AVRational[] array)
    {
        fixed (_AVRational* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 25) return; } }
    }
    public static implicit operator _AVRational[](_AVRational25 @struct) => @struct.ToArray();
}

public unsafe struct _AVRational25x25 : IFixedArray<_AVRational25>
{
    public static readonly int ArrayLength = 25;
    public int Length => 25;
    _AVRational25 _0; _AVRational25 _1; _AVRational25 _2; _AVRational25 _3; _AVRational25 _4; _AVRational25 _5; _AVRational25 _6; _AVRational25 _7; _AVRational25 _8; _AVRational25 _9; _AVRational25 _10; _AVRational25 _11; _AVRational25 _12; _AVRational25 _13; _AVRational25 _14; _AVRational25 _15; _AVRational25 _16; _AVRational25 _17; _AVRational25 _18; _AVRational25 _19; _AVRational25 _20; _AVRational25 _21; _AVRational25 _22; _AVRational25 _23; _AVRational25 _24;
    
    public _AVRational25 this[uint i]
    {
        get { if (i >= 25) throw new ArgumentOutOfRangeException(); fixed (_AVRational25* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 25) throw new ArgumentOutOfRangeException(); fixed (_AVRational25* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public _AVRational25[] ToArray()
    {
        fixed (_AVRational25* p0 = &_0) { var a = new _AVRational25[25]; for (uint i = 0; i < 25; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(_AVRational25[] array)
    {
        fixed (_AVRational25* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 25) return; } }
    }
    public static implicit operator _AVRational25[](_AVRational25x25 @struct) => @struct.ToArray();
}

public unsafe struct ushort32 : IFixedArray<ushort>
{
    public static readonly int ArrayLength = 32;
    public int Length => 32;
    fixed ushort _[32];
    
    public ushort this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public ushort[] ToArray()
    {
        var a = new ushort[32]; for (uint i = 0; i < 32; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(ushort[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 32) return; }
    }
    public static implicit operator ushort[](ushort32 @struct) => @struct.ToArray();
}

