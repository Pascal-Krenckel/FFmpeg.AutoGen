using System;
using System.Collections.Generic;
using System.Linq;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

internal record FunctionDefinitionBase : IDefinition, ICanGenerateXmlDoc, IObsoletionAware
{
    public TypeDefinition ReturnType { get; set; }
    public FunctionParameter[] Parameters { get; set; } = Array.Empty<FunctionParameter>();
    public string ReturnComment { get; set; }
    public string Content { get; set; }
    public string Name { get; set; }

    public string DelegateName { get => field ?? Name; set; }

    public Obsoletion Obsoletion { get; set; }

    public virtual bool Equals(FunctionDefinitionBase @base) => @base is not null && Enumerable.SequenceEqual(Parameters, @base.Parameters) && Name == @base.Name;
    public bool Equals(IDefinition other) => other is FunctionDefinitionBase @base && Equals(@base);
    public override int GetHashCode() => HashCode.Combine(Parameters, Name);
}
