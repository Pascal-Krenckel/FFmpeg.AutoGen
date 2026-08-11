using System;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

internal interface IDefinition : IEquatable<IDefinition>
{
    string Name { get; }
}
