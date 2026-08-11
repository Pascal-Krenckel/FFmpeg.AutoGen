using System;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

internal record MacroDefinition : IDefinition, ICanGenerateXmlDoc
{
    public string Expression { get; set; }
    public string TypeName { get; set; }
    public bool IsValid { get; set; }
    public bool IsConst { get; set; }
    public string Content { get; set; }
    public string Name { get; init; }

    public virtual bool Equals(MacroDefinition definition) => definition is not null && Name == definition.Name;
    public bool Equals(IDefinition other) => other is MacroDefinition definition && Equals(definition);
    public override int GetHashCode() => HashCode.Combine(Name);
}
