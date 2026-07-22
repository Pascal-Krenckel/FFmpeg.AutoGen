using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using System;
using System.Collections.Generic;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;

internal sealed record GenerationContext
{
    public string Namespace { get; init; } = string.Empty;
    public string TypeName { get; init; } = string.Empty;
    public bool SuppressUnmanagedCodeSecurity { get; init; }
    public bool IsLegacyGenerationOn { get; init; }
    public Dictionary<string, int> LibraryVersionMap { get; init; } = [];
    public IDefinition[] Definitions { get; init; } = Array.Empty<IDefinition>();
    public Dictionary<string, InlineFunctionDefinition> ExistingInlineFunctionMap { get; init; } = [];
    public string SolutionDir { get; init; } = string.Empty;
    public string OutputDir { get; init; } = string.Empty;
    public string FileHeader { get; init; } = string.Empty;
}
