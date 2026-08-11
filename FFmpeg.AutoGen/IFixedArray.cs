namespace FFmpeg.AutoGen;

public interface IFixedArray
{
    int Length { get; }
}

public interface IFixedArray<T> : IFixedArray
{
    ref T this[int index] { get; }
    ref T this[uint index] { get; }

    T[] ToArray();
    void UpdateFrom(T[] array);
    ref T GetPinnableReference();

    //public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref GetPinnableReference(), Length); 
}

public unsafe interface IFixedPtrArray : IFixedArray
{
    void* this[int index] { get; set; }
    void* this[uint index] { get; set; }

    void*[] ToArray();
    void UpdateFrom(void*[] array);

    ref void* GetPinnableReference();
}

public unsafe interface IFixedPtrArray<T> : IFixedPtrArray where T : unmanaged
{
    T* this[int index] { get; set; }
    T* this[uint index] { get; set; }

    T*[] ToArray();
    void UpdateFrom(T*[] array);

    ref T* GetPinnableReference();
}