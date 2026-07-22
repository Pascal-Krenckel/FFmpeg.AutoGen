using CppSharp.AST;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using System.Collections.Generic;
using System.Linq;
using MacroDefinition = FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions.MacroDefinition;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processing;

internal sealed class ASTProcessor
{
    private readonly ProcessingContext _context;
    private readonly EnumerationProcessor _enumerationProcessor;
    private readonly FunctionProcessor _functionProcessor;
    private readonly MacroPostProcessor _macroPostProcessor;
    private readonly MacroProcessor _macroProcessor;
    private readonly StructureProcessor _structureProcessor;

    public ASTProcessor(ProcessingContext context)
    {
        _context = context;
        _functionProcessor = new FunctionProcessor(context);
        _structureProcessor = new StructureProcessor(context);
        _enumerationProcessor = new EnumerationProcessor(context);
        _macroProcessor = new MacroProcessor(context);
        _macroPostProcessor = new MacroPostProcessor(context);

        // inject cross processor dependencies
        _structureProcessor.EnumerationProcessor = _enumerationProcessor;
        _structureProcessor.FunctionProcessor = _functionProcessor;
        _functionProcessor.StructureProcessor = _structureProcessor;
    }

    public void Process(ASTContext context)
    {
        IEnumerable<TranslationUnit> units = context.TranslationUnits.Where(x => !x.IsSystemHeader);

        foreach (TranslationUnit translationUnit in units)
        {
            _macroProcessor.Process(translationUnit);
            _enumerationProcessor.Process(translationUnit);
            _structureProcessor.Process(translationUnit);
            _functionProcessor.Process(translationUnit);
        }

        // add all enums as known macros  
        EnumerationDefinition[] enums = _context.Definitions.OfType<EnumerationDefinition>().ToArray();

        foreach (EnumerationDefinition @enum in enums)
            foreach (EnumerationItem item in @enum.Items)
            {
                string key = @enum.Name + "." + item.Name;
                if (!_context.WellKnownMacros.ContainsKey(key))
                    _context.WellKnownMacros.Add(key, new TypeOrAlias(typeof(int)));
                if (!_context.WellKnownEnumItems.ContainsKey(item.Name))
                    _context.WellKnownEnumItems.Add(item.Name, item.Value);
            }

        MacroDefinition[] macros = _context.Definitions.OfType<MacroDefinition>().ToArray();
        _macroPostProcessor.Process(macros);
    }
}
