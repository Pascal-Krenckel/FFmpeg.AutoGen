using System;
using System.Collections.Generic;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

internal record FunctionParameter : ICanGenerateXmlDoc, IEquatable<FunctionParameter>
{
    public string Name { get; init; }
    public TypeDefinition Type { get; init; }
    public string Content { get; init; }
    public bool IsConstant { get; init; }
    public bool IsIndirect { get; init; }
    public bool ByReference { get; init; }

    public virtual bool Equals(FunctionParameter parameter) => parameter is not null && EqualityComparer<string>.Default.Equals(Type.Name, parameter.Type.Name);
    public override int GetHashCode() => HashCode.Combine(Type);
}
