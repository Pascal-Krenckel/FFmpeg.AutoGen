using System;
using System.Collections.Generic;
using System.Linq;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;

internal sealed class InlineFunctionsGenerator : GeneratorBase<InlineFunctionDefinition>
{
    public InlineFunctionsGenerator(string path, GenerationContext context) : base(path, context) => IsTypeGenerationOn = true;

    public static void Generate(string path, GenerationContext context)
    {
        using var g = new InlineFunctionsGenerator(path, context);
        g.Generate();
    }

    public override IEnumerable<string> Usings()
    {
        yield return "System";
        yield return "System.Runtime.CompilerServices";
    }

    protected override IEnumerable<InlineFunctionDefinition> Query(IEnumerable<InlineFunctionDefinition> functions) => base.Query(functions).Select(RewriteFunctionBody);

    protected override void GenerateDefinition(InlineFunctionDefinition function)
    {
        function.ReturnType.Attributes.ToList().ForEach(WriteLine);
        var parameters = ParametersHelper.GetParameters(function.Parameters, Context.IsLegacyGenerationOn, false);

        this.WriteSummary(function);
        function.Parameters.ToList().ForEach(p => this.WriteParam(p, p.Name));
        this.WriteReturnComment(function);

        this.WriteObsoletion(function);
        this.WriteAggressiveInlining();
        WriteLine($"public static {function.ReturnType.Name} {function.Name}({parameters})");

        var lines = function.Body.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        lines.ForEach(WriteLineWithoutIntent);
        WriteLine($"// original body hash: {function.OriginalBodyHash}");
        WriteLine();
    }
    
    private void WriteAggressiveInlining()
    {
        WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
    }

    private InlineFunctionDefinition RewriteFunctionBody(InlineFunctionDefinition function) =>
        Context.ExistingInlineFunctionMap.TryGetValue(function.Name, out var existing) && function.OriginalBodyHash == existing.OriginalBodyHash
            ? function with { Body = existing.Body }
            : function;
}
