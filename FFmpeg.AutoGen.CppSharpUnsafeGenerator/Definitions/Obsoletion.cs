namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

public readonly record struct Obsoletion
{
    public bool IsObsolete { get; init; }
    public string Message { get; init; }
}
