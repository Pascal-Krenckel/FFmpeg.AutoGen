using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;

internal sealed class StructuresGenerator : GeneratorBase<StructureDefinition>
{
    public StructuresGenerator(string path, GenerationContext context) : base(path, context)
    {
    }

    public static void Generate(string path, GenerationContext context)
    {
        using StructuresGenerator g = new(path, context);
        g.Generate();
    }

    public override IEnumerable<string> Usings()
    {
        yield return "System";
        yield return "System.Runtime.InteropServices";
    }

    protected override void WriteConditionalUsings()
    {
        WriteLineWithoutIntent("#if NET6_0_OR_GREATER");
        WriteLineWithoutIntent("using CLong = System.Runtime.InteropServices.CLong;");
        WriteLineWithoutIntent("using CULong = System.Runtime.InteropServices.CULong;");
        WriteLineWithoutIntent("#endif");
        WriteLine();
    }

    protected override IEnumerable<StructureDefinition> Query(IEnumerable<StructureDefinition> arrays)
        => arrays.OrderBy(s => s.IsComplete ? 0 : 1).ThenBy(s => s.Name);

    protected override void GenerateDefinition(StructureDefinition structure)
    {
        GenerateWindowsDefinition(structure);
        this.WriteSummary(structure);
        if (!structure.IsComplete)
            WriteLine("/// <remarks>This struct is incomplete.</remarks>");
        this.WriteObsoletion(structure);
        if (structure.IsUnion)
            WriteLine("[StructLayout(LayoutKind.Explicit)]");
        WriteLine($"public unsafe partial struct {structure.Name}");

        using (BeginBlock())
            foreach (StructureField field in structure.Fields)
            {
                this.WriteSummary(field);
                this.WriteObsoletion(field);
                if (structure.IsUnion)
                    WriteLine("[FieldOffset(0)]");
                var typeName = ParametersHelper.GetTypeName(field.FieldType, Context.IsLegacyGenerationOn);

                if (!Context.IsLegacyGenerationOn && typeName.Contains("_array"))
                {

                }
                WriteLine($"public {typeName} @{field.Name};");
            }

        WriteLine();
    }

    private void GenerateWindowsDefinition(StructureDefinition structure)
    {
        if(structure.Fields.Any(f => f.FieldType.Name.Equals("CLONG",StringComparison.OrdinalIgnoreCase) || f.FieldType.Name.Equals("CULONG", StringComparison.OrdinalIgnoreCase))))
        {
            StructureDefinition copy = new()
            {
                Content = structure.Content,
                IsComplete = structure.IsComplete,
                IsUnion = structure.IsUnion,
                Obsoletion = structure.Obsoletion,
                TypeName = structure.TypeName,
                Name = structure.Name + "_win",
                Fields = new StructureField[structure.Fields.Length]
            };
            for(int i = 0; i < structure.Fields.Length; i++)
            {
                if(structure.Fields[i].FieldType.Name.Equals("CLONG", StringComparison.OrdinalIgnoreCase))
                {
                    copy.Fields[i] = new StructureField
                    {
                        Content = structure.Fields[i].Content,
                        Obsoletion = structure.Fields[i].Obsoletion,
                        Name = structure.Fields[i].Name,
                       
                        FieldType = new TypeDefinition() { Name = "int"}
                    };
                }
                else if (structure.Fields[i].FieldType.Name.Equals("CULONG", StringComparison.OrdinalIgnoreCase))
                {
                    copy.Fields[i] = new StructureField
                    {
                        Content = structure.Fields[i].Content,
                        Obsoletion = structure.Fields[i].Obsoletion,
                        Name = structure.Fields[i].Name,

                        FieldType = new TypeDefinition() { Name = "uint" }
                    };
                }
                else
                {
                    copy.Fields[i] = structure.Fields[i];
                }
            }

            GenerateDefinition(copy);
        }

    }
}
