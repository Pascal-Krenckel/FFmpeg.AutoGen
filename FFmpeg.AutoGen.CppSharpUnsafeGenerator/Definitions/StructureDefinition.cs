using System;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

internal record StructureDefinition : NamedDefinition, IDefinition
{
    public StructureField[] Fields { get; set; } = Array.Empty<StructureField>();
    public bool IsComplete { get; set; }
    public bool IsUnion { get; init; }


    public virtual bool Equals(StructureDefinition definition) => definition is not null && base.Equals(definition) && Name == definition.Name;
    public bool Equals(IDefinition other) => other is StructureDefinition definition && Equals(definition);
    public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), Name);
}
