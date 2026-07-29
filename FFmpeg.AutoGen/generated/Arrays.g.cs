using System;

namespace FFmpeg.AutoGen;

public unsafe struct _AVRational_array2 : IFixedArray<_AVRational>
{
    public static readonly int Size = 2;
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
    public static implicit operator _AVRational[](_AVRational_array2 @struct) => @struct.ToArray();
}

public unsafe struct double_array2 : IFixedArray<double>
{
    public static readonly int Size = 2;
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
    public static implicit operator double[](double_array2 @struct) => @struct.ToArray();
}

public unsafe struct short_array2 : IFixedArray<short>
{
    public static readonly int Size = 2;
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
    public static implicit operator short[](short_array2 @struct) => @struct.ToArray();
}

public unsafe struct void_ptrArray2 : IFixedArray
{
    public static readonly int Size = 2;
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
    public static implicit operator void*[](void_ptrArray2 @struct) => @struct.ToArray();
}

public unsafe struct _AVHDRPlusColorTransformParams_array3 : IFixedArray<_AVHDRPlusColorTransformParams>
{
    public static readonly int Size = 3;
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
    public static implicit operator _AVHDRPlusColorTransformParams[](_AVHDRPlusColorTransformParams_array3 @struct) => @struct.ToArray();
}

public unsafe struct _AVRational_array3 : IFixedArray<_AVRational>
{
    public static readonly int Size = 3;
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
    public static implicit operator _AVRational[](_AVRational_array3 @struct) => @struct.ToArray();
}

public unsafe struct _AVRational_array3x2 : IFixedArray<_AVRational_array2>
{
    public static readonly int Size = 3;
    public int Length => 3;
    _AVRational_array2 _0; _AVRational_array2 _1; _AVRational_array2 _2;
    
    public _AVRational_array2 this[uint i]
    {
        get { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (_AVRational_array2* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (_AVRational_array2* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public _AVRational_array2[] ToArray()
    {
        fixed (_AVRational_array2* p0 = &_0) { var a = new _AVRational_array2[3]; for (uint i = 0; i < 3; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(_AVRational_array2[] array)
    {
        fixed (_AVRational_array2* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 3) return; } }
    }
    public static implicit operator _AVRational_array2[](_AVRational_array3x2 @struct) => @struct.ToArray();
}

public unsafe struct short_array3x2 : IFixedArray<short_array2>
{
    public static readonly int Size = 3;
    public int Length => 3;
    short_array2 _0; short_array2 _1; short_array2 _2;
    
    public short_array2 this[uint i]
    {
        get { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (short_array2* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 3) throw new ArgumentOutOfRangeException(); fixed (short_array2* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public short_array2[] ToArray()
    {
        fixed (short_array2* p0 = &_0) { var a = new short_array2[3]; for (uint i = 0; i < 3; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(short_array2[] array)
    {
        fixed (short_array2* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 3) return; } }
    }
    public static implicit operator short_array2[](short_array3x2 @struct) => @struct.ToArray();
}

public unsafe struct _AVComponentDescriptor_array4 : IFixedArray<_AVComponentDescriptor>
{
    public static readonly int Size = 4;
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
    public static implicit operator _AVComponentDescriptor[](_AVComponentDescriptor_array4 @struct) => @struct.ToArray();
}

public unsafe struct byte_ptrArray4 : IFixedArray
{
    public static readonly int Size = 4;
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
    public static implicit operator byte*[](byte_ptrArray4 @struct) => @struct.ToArray();
}

public unsafe struct byte_array4 : IFixedArray<byte>
{
    public static readonly int Size = 4;
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
    public static implicit operator byte[](byte_array4 @struct) => @struct.ToArray();
}

public unsafe struct int_array4 : IFixedArray<int>
{
    public static readonly int Size = 4;
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
    public static implicit operator int[](int_array4 @struct) => @struct.ToArray();
}

public unsafe struct long_array4 : IFixedArray<long>
{
    public static readonly int Size = 4;
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
    public static implicit operator long[](long_array4 @struct) => @struct.ToArray();
}

public unsafe struct uint_array4 : IFixedArray<uint>
{
    public static readonly int Size = 4;
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
    public static implicit operator uint[](uint_array4 @struct) => @struct.ToArray();
}

public unsafe struct ulong_array4 : IFixedArray<ulong>
{
    public static readonly int Size = 4;
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
    public static implicit operator ulong[](ulong_array4 @struct) => @struct.ToArray();
}

public unsafe struct int_array7 : IFixedArray<int>
{
    public static readonly int Size = 7;
    public int Length => 7;
    fixed int _[7];
    
    public int this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public int[] ToArray()
    {
        var a = new int[7]; for (uint i = 0; i < 7; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(int[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 7) return; }
    }
    public static implicit operator int[](int_array7 @struct) => @struct.ToArray();
}

public unsafe struct __cl_mem_ptrArray8 : IFixedArray
{
    public static readonly int Size = 8;
    public int Length => 8;
    __cl_mem* _0; __cl_mem* _1; __cl_mem* _2; __cl_mem* _3; __cl_mem* _4; __cl_mem* _5; __cl_mem* _6; __cl_mem* _7;
    
    public __cl_mem* this[uint i]
    {
        get { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (__cl_mem** p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (__cl_mem** p0 = &_0) { *(p0 + i) = value;  } }
    }
    public __cl_mem*[] ToArray()
    {
        fixed (__cl_mem** p0 = &_0) { var a = new __cl_mem*[8]; for (uint i = 0; i < 8; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(__cl_mem*[] array)
    {
        fixed (__cl_mem** p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 8) return; } }
    }
    public static implicit operator __cl_mem*[](__cl_mem_ptrArray8 @struct) => @struct.ToArray();
}

public unsafe struct _AVBufferRef_ptrArray8 : IFixedArray
{
    public static readonly int Size = 8;
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
    public static implicit operator _AVBufferRef*[](_AVBufferRef_ptrArray8 @struct) => @struct.ToArray();
}

public unsafe struct _VkAccessFlagBits_array8 : IFixedArray<_VkAccessFlagBits>
{
    public static readonly int Size = 8;
    public int Length => 8;
    _VkAccessFlagBits _0; _VkAccessFlagBits _1; _VkAccessFlagBits _2; _VkAccessFlagBits _3; _VkAccessFlagBits _4; _VkAccessFlagBits _5; _VkAccessFlagBits _6; _VkAccessFlagBits _7;
    
    public _VkAccessFlagBits this[uint i]
    {
        get { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (_VkAccessFlagBits* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (_VkAccessFlagBits* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public _VkAccessFlagBits[] ToArray()
    {
        fixed (_VkAccessFlagBits* p0 = &_0) { var a = new _VkAccessFlagBits[8]; for (uint i = 0; i < 8; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(_VkAccessFlagBits[] array)
    {
        fixed (_VkAccessFlagBits* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 8) return; } }
    }
    public static implicit operator _VkAccessFlagBits[](_VkAccessFlagBits_array8 @struct) => @struct.ToArray();
}

public unsafe struct _VkDeviceMemory_T_ptrArray8 : IFixedArray
{
    public static readonly int Size = 8;
    public int Length => 8;
    _VkDeviceMemory_T* _0; _VkDeviceMemory_T* _1; _VkDeviceMemory_T* _2; _VkDeviceMemory_T* _3; _VkDeviceMemory_T* _4; _VkDeviceMemory_T* _5; _VkDeviceMemory_T* _6; _VkDeviceMemory_T* _7;
    
    public _VkDeviceMemory_T* this[uint i]
    {
        get { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (_VkDeviceMemory_T** p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (_VkDeviceMemory_T** p0 = &_0) { *(p0 + i) = value;  } }
    }
    public _VkDeviceMemory_T*[] ToArray()
    {
        fixed (_VkDeviceMemory_T** p0 = &_0) { var a = new _VkDeviceMemory_T*[8]; for (uint i = 0; i < 8; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(_VkDeviceMemory_T*[] array)
    {
        fixed (_VkDeviceMemory_T** p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 8) return; } }
    }
    public static implicit operator _VkDeviceMemory_T*[](_VkDeviceMemory_T_ptrArray8 @struct) => @struct.ToArray();
}

public unsafe struct _VkFormat_array8 : IFixedArray<_VkFormat>
{
    public static readonly int Size = 8;
    public int Length => 8;
    _VkFormat _0; _VkFormat _1; _VkFormat _2; _VkFormat _3; _VkFormat _4; _VkFormat _5; _VkFormat _6; _VkFormat _7;
    
    public _VkFormat this[uint i]
    {
        get { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (_VkFormat* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (_VkFormat* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public _VkFormat[] ToArray()
    {
        fixed (_VkFormat* p0 = &_0) { var a = new _VkFormat[8]; for (uint i = 0; i < 8; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(_VkFormat[] array)
    {
        fixed (_VkFormat* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 8) return; } }
    }
    public static implicit operator _VkFormat[](_VkFormat_array8 @struct) => @struct.ToArray();
}

public unsafe struct _VkImage_T_ptrArray8 : IFixedArray
{
    public static readonly int Size = 8;
    public int Length => 8;
    _VkImage_T* _0; _VkImage_T* _1; _VkImage_T* _2; _VkImage_T* _3; _VkImage_T* _4; _VkImage_T* _5; _VkImage_T* _6; _VkImage_T* _7;
    
    public _VkImage_T* this[uint i]
    {
        get { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (_VkImage_T** p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (_VkImage_T** p0 = &_0) { *(p0 + i) = value;  } }
    }
    public _VkImage_T*[] ToArray()
    {
        fixed (_VkImage_T** p0 = &_0) { var a = new _VkImage_T*[8]; for (uint i = 0; i < 8; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(_VkImage_T*[] array)
    {
        fixed (_VkImage_T** p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 8) return; } }
    }
    public static implicit operator _VkImage_T*[](_VkImage_T_ptrArray8 @struct) => @struct.ToArray();
}

public unsafe struct _VkImageLayout_array8 : IFixedArray<_VkImageLayout>
{
    public static readonly int Size = 8;
    public int Length => 8;
    _VkImageLayout _0; _VkImageLayout _1; _VkImageLayout _2; _VkImageLayout _3; _VkImageLayout _4; _VkImageLayout _5; _VkImageLayout _6; _VkImageLayout _7;
    
    public _VkImageLayout this[uint i]
    {
        get { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (_VkImageLayout* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (_VkImageLayout* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public _VkImageLayout[] ToArray()
    {
        fixed (_VkImageLayout* p0 = &_0) { var a = new _VkImageLayout[8]; for (uint i = 0; i < 8; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(_VkImageLayout[] array)
    {
        fixed (_VkImageLayout* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 8) return; } }
    }
    public static implicit operator _VkImageLayout[](_VkImageLayout_array8 @struct) => @struct.ToArray();
}

public unsafe struct _VkSemaphore_T_ptrArray8 : IFixedArray
{
    public static readonly int Size = 8;
    public int Length => 8;
    _VkSemaphore_T* _0; _VkSemaphore_T* _1; _VkSemaphore_T* _2; _VkSemaphore_T* _3; _VkSemaphore_T* _4; _VkSemaphore_T* _5; _VkSemaphore_T* _6; _VkSemaphore_T* _7;
    
    public _VkSemaphore_T* this[uint i]
    {
        get { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (_VkSemaphore_T** p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (_VkSemaphore_T** p0 = &_0) { *(p0 + i) = value;  } }
    }
    public _VkSemaphore_T*[] ToArray()
    {
        fixed (_VkSemaphore_T** p0 = &_0) { var a = new _VkSemaphore_T*[8]; for (uint i = 0; i < 8; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(_VkSemaphore_T*[] array)
    {
        fixed (_VkSemaphore_T** p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 8) return; } }
    }
    public static implicit operator _VkSemaphore_T*[](_VkSemaphore_T_ptrArray8 @struct) => @struct.ToArray();
}

public unsafe struct byte_ptrArray8 : IFixedArray
{
    public static readonly int Size = 8;
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
    public static implicit operator byte*[](byte_ptrArray8 @struct) => @struct.ToArray();
}

public unsafe struct byte_array8 : IFixedArray<byte>
{
    public static readonly int Size = 8;
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
    public static implicit operator byte[](byte_array8 @struct) => @struct.ToArray();
}

public unsafe struct int_array8 : IFixedArray<int>
{
    public static readonly int Size = 8;
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
    public static implicit operator int[](int_array8 @struct) => @struct.ToArray();
}

public unsafe struct long_array8 : IFixedArray<long>
{
    public static readonly int Size = 8;
    public int Length => 8;
    fixed long _[8];
    
    public long this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public long[] ToArray()
    {
        var a = new long[8]; for (uint i = 0; i < 8; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(long[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 8) return; }
    }
    public static implicit operator long[](long_array8 @struct) => @struct.ToArray();
}

public unsafe struct uint_array8 : IFixedArray<uint>
{
    public static readonly int Size = 8;
    public int Length => 8;
    fixed uint _[8];
    
    public uint this[uint i]
    {
        get => _[i];
        set => _[i] = value;
    }
    public uint[] ToArray()
    {
        var a = new uint[8]; for (uint i = 0; i < 8; i++) a[i] = _[i]; return a;
    }
    public void UpdateFrom(uint[] array)
    {
        uint i = 0; foreach(var value in array) { _[i++] = value; if (i >= 8) return; }
    }
    public static implicit operator uint[](uint_array8 @struct) => @struct.ToArray();
}

public unsafe struct ulong_array8 : IFixedArray<ulong>
{
    public static readonly int Size = 8;
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
    public static implicit operator ulong[](ulong_array8 @struct) => @struct.ToArray();
}

public unsafe struct void_ptrArray8 : IFixedArray
{
    public static readonly int Size = 8;
    public int Length => 8;
    void* _0; void* _1; void* _2; void* _3; void* _4; void* _5; void* _6; void* _7;
    
    public void* this[uint i]
    {
        get { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (void** p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 8) throw new ArgumentOutOfRangeException(); fixed (void** p0 = &_0) { *(p0 + i) = value;  } }
    }
    public void*[] ToArray()
    {
        fixed (void** p0 = &_0) { var a = new void*[8]; for (uint i = 0; i < 8; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(void*[] array)
    {
        fixed (void** p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 8) return; } }
    }
    public static implicit operator void*[](void_ptrArray8 @struct) => @struct.ToArray();
}

public unsafe struct int_array9 : IFixedArray<int>
{
    public static readonly int Size = 9;
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
    public static implicit operator int[](int_array9 @struct) => @struct.ToArray();
}

public unsafe struct _AVHDRPlusPercentile_array15 : IFixedArray<_AVHDRPlusPercentile>
{
    public static readonly int Size = 15;
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
    public static implicit operator _AVHDRPlusPercentile[](_AVHDRPlusPercentile_array15 @struct) => @struct.ToArray();
}

public unsafe struct _AVRational_array15 : IFixedArray<_AVRational>
{
    public static readonly int Size = 15;
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
    public static implicit operator _AVRational[](_AVRational_array15 @struct) => @struct.ToArray();
}

public unsafe struct byte_array16 : IFixedArray<byte>
{
    public static readonly int Size = 16;
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
    public static implicit operator byte[](byte_array16 @struct) => @struct.ToArray();
}

public unsafe struct _AVRational_array25 : IFixedArray<_AVRational>
{
    public static readonly int Size = 25;
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
    public static implicit operator _AVRational[](_AVRational_array25 @struct) => @struct.ToArray();
}

public unsafe struct _AVRational_array25x25 : IFixedArray<_AVRational_array25>
{
    public static readonly int Size = 25;
    public int Length => 25;
    _AVRational_array25 _0; _AVRational_array25 _1; _AVRational_array25 _2; _AVRational_array25 _3; _AVRational_array25 _4; _AVRational_array25 _5; _AVRational_array25 _6; _AVRational_array25 _7; _AVRational_array25 _8; _AVRational_array25 _9; _AVRational_array25 _10; _AVRational_array25 _11; _AVRational_array25 _12; _AVRational_array25 _13; _AVRational_array25 _14; _AVRational_array25 _15; _AVRational_array25 _16; _AVRational_array25 _17; _AVRational_array25 _18; _AVRational_array25 _19; _AVRational_array25 _20; _AVRational_array25 _21; _AVRational_array25 _22; _AVRational_array25 _23; _AVRational_array25 _24;
    
    public _AVRational_array25 this[uint i]
    {
        get { if (i >= 25) throw new ArgumentOutOfRangeException(); fixed (_AVRational_array25* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 25) throw new ArgumentOutOfRangeException(); fixed (_AVRational_array25* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public _AVRational_array25[] ToArray()
    {
        fixed (_AVRational_array25* p0 = &_0) { var a = new _AVRational_array25[25]; for (uint i = 0; i < 25; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(_AVRational_array25[] array)
    {
        fixed (_AVRational_array25* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 25) return; } }
    }
    public static implicit operator _AVRational_array25[](_AVRational_array25x25 @struct) => @struct.ToArray();
}

public unsafe struct _AVVulkanDeviceQueueFamily_array64 : IFixedArray<_AVVulkanDeviceQueueFamily>
{
    public static readonly int Size = 64;
    public int Length => 64;
    _AVVulkanDeviceQueueFamily _0; _AVVulkanDeviceQueueFamily _1; _AVVulkanDeviceQueueFamily _2; _AVVulkanDeviceQueueFamily _3; _AVVulkanDeviceQueueFamily _4; _AVVulkanDeviceQueueFamily _5; _AVVulkanDeviceQueueFamily _6; _AVVulkanDeviceQueueFamily _7; _AVVulkanDeviceQueueFamily _8; _AVVulkanDeviceQueueFamily _9; _AVVulkanDeviceQueueFamily _10; _AVVulkanDeviceQueueFamily _11; _AVVulkanDeviceQueueFamily _12; _AVVulkanDeviceQueueFamily _13; _AVVulkanDeviceQueueFamily _14; _AVVulkanDeviceQueueFamily _15; _AVVulkanDeviceQueueFamily _16; _AVVulkanDeviceQueueFamily _17; _AVVulkanDeviceQueueFamily _18; _AVVulkanDeviceQueueFamily _19; _AVVulkanDeviceQueueFamily _20; _AVVulkanDeviceQueueFamily _21; _AVVulkanDeviceQueueFamily _22; _AVVulkanDeviceQueueFamily _23; _AVVulkanDeviceQueueFamily _24; _AVVulkanDeviceQueueFamily _25; _AVVulkanDeviceQueueFamily _26; _AVVulkanDeviceQueueFamily _27; _AVVulkanDeviceQueueFamily _28; _AVVulkanDeviceQueueFamily _29; _AVVulkanDeviceQueueFamily _30; _AVVulkanDeviceQueueFamily _31; _AVVulkanDeviceQueueFamily _32; _AVVulkanDeviceQueueFamily _33; _AVVulkanDeviceQueueFamily _34; _AVVulkanDeviceQueueFamily _35; _AVVulkanDeviceQueueFamily _36; _AVVulkanDeviceQueueFamily _37; _AVVulkanDeviceQueueFamily _38; _AVVulkanDeviceQueueFamily _39; _AVVulkanDeviceQueueFamily _40; _AVVulkanDeviceQueueFamily _41; _AVVulkanDeviceQueueFamily _42; _AVVulkanDeviceQueueFamily _43; _AVVulkanDeviceQueueFamily _44; _AVVulkanDeviceQueueFamily _45; _AVVulkanDeviceQueueFamily _46; _AVVulkanDeviceQueueFamily _47; _AVVulkanDeviceQueueFamily _48; _AVVulkanDeviceQueueFamily _49; _AVVulkanDeviceQueueFamily _50; _AVVulkanDeviceQueueFamily _51; _AVVulkanDeviceQueueFamily _52; _AVVulkanDeviceQueueFamily _53; _AVVulkanDeviceQueueFamily _54; _AVVulkanDeviceQueueFamily _55; _AVVulkanDeviceQueueFamily _56; _AVVulkanDeviceQueueFamily _57; _AVVulkanDeviceQueueFamily _58; _AVVulkanDeviceQueueFamily _59; _AVVulkanDeviceQueueFamily _60; _AVVulkanDeviceQueueFamily _61; _AVVulkanDeviceQueueFamily _62; _AVVulkanDeviceQueueFamily _63;
    
    public _AVVulkanDeviceQueueFamily this[uint i]
    {
        get { if (i >= 64) throw new ArgumentOutOfRangeException(); fixed (_AVVulkanDeviceQueueFamily* p0 = &_0) { return *(p0 + i); } }
        set { if (i >= 64) throw new ArgumentOutOfRangeException(); fixed (_AVVulkanDeviceQueueFamily* p0 = &_0) { *(p0 + i) = value;  } }
    }
    public _AVVulkanDeviceQueueFamily[] ToArray()
    {
        fixed (_AVVulkanDeviceQueueFamily* p0 = &_0) { var a = new _AVVulkanDeviceQueueFamily[64]; for (uint i = 0; i < 64; i++) a[i] = *(p0 + i); return a; }
    }
    public void UpdateFrom(_AVVulkanDeviceQueueFamily[] array)
    {
        fixed (_AVVulkanDeviceQueueFamily* p0 = &_0) { uint i = 0; foreach(var value in array) { *(p0 + i++) = value; if (i >= 64) return; } }
    }
    public static implicit operator _AVVulkanDeviceQueueFamily[](_AVVulkanDeviceQueueFamily_array64 @struct) => @struct.ToArray();
}

