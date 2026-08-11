using System;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

internal record TypeDefinition : IDefinition
{
    public string[] Attributes { get; init; } = [];
    public bool ByReference { get; init; }
    public string Name { get; init; }
    public string LegacyName { get; init; }


    public virtual bool Equals(TypeDefinition definition) => definition is not null && Name == definition.Name;
    public bool Equals(IDefinition other) => other is TypeDefinition definition && Equals(definition);
    public override int GetHashCode() => HashCode.Combine(Name);
}
