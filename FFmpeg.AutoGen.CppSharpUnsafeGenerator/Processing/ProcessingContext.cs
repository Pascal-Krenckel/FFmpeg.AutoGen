using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using System.Collections.Generic;
using System.Linq;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processing;

internal sealed record ProcessingContext
{
    public HashSet<string> IgnoreUnitNames { get; init; } = [];
    public Dictionary<string, TypeOrAlias> TypeAliases { get; init; } = [];
    public Dictionary<string, TypeOrAlias> WellKnownMacros { get; init; } = [];
    public Dictionary<string, string> WellKnownEnumItems { get; init; } = [];
    public Dictionary<string, FunctionExport> FunctionExportMap { get; init; } = [];
    public List<IDefinition> Definitions { get; init; } = [];
    public bool NoCustomStringMarshal { get; init; } = false;

    public void AddDefinition(IDefinition definition)
    {
        if (IgnoreUnitNames.Contains(definition.Name))
            return;
        IDefinition existing = Definitions.FirstOrDefault(x => x.Name == definition.Name);

        if (existing != null)
            _ = Definitions.Remove(existing);

        Definitions.Add(definition);
    }
}
