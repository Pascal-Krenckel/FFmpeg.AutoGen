using System;
using System.Collections.Generic;
using System.Linq;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

internal record DelegateDefinition : TypeDefinition
{
    public string FunctionName { get; init; }
    public TypeDefinition ReturnType { get; init; }
    public FunctionParameter[] Parameters { get; init; } = [];

    public virtual bool Equals(DelegateDefinition definition) => definition is not null && base.Equals(definition) && FunctionName == definition.FunctionName && Enumerable.SequenceEqual(Parameters,definition.Parameters);
    public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), FunctionName, Parameters);
}
