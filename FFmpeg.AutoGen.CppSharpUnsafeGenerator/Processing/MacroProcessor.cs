using CppSharp.AST;
using System.Linq;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processing;

internal class MacroProcessor
{
    private readonly ProcessingContext _context;

    public MacroProcessor(ProcessingContext context) => _context = context;

    public void Process(TranslationUnit translationUnit)
    {
        foreach (MacroDefinition macro in translationUnit.PreprocessedEntities.OfType<MacroDefinition>()
                     .Where(x => !string.IsNullOrWhiteSpace(x.Expression)))
        {
            Definitions.MacroDefinition macroDefinition = new()
            {
                Name = macro.Name,
                Expression = macro.Expression
            };
            _context.AddDefinition(macroDefinition);
        }
    }
}
