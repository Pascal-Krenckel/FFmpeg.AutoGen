using System;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

internal record EnumerationDefinition : NamedDefinition, IDefinition
{
    public EnumerationItem[] Items { get; init; } = [];

    public virtual bool Equals(EnumerationDefinition definition) => definition is not null && base.Equals(definition) && Name == definition.Name;
    public bool Equals(IDefinition other) => other is EnumerationDefinition definition && Equals(definition);
    public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), Name);
}
