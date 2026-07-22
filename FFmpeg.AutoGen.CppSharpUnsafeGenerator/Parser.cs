using CppSharp;
using CppSharp.AST;
using CppSharp.Parser;
using System;
using System.Collections.Generic;
using ClangParser = CppSharp.ClangParser;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator;

internal sealed class Parser
{
    private bool _hasParsingErrors;

    public string[] Defines { get; init; } = [];
    public string[] IncludeDirs { get; init; } = [];

    public ASTContext Parse(params string[] sourceFiles)
    {
        _hasParsingErrors = false;
        ASTContext context = ParseInternal(sourceFiles);
        foreach (TranslationUnit unit in context.TranslationUnits)
        {
            foreach (Class @class in unit.Classes)
                if (!string.IsNullOrEmpty(@class.Name))
                    @class.Name = "_" + @class.Name;
            foreach (Enumeration @enum in unit.Enums)
                if (!string.IsNullOrEmpty(@enum.Name))
                    @enum.Name = "_" + @enum.Name;
            foreach (TypedefNameDecl typedef in unit.Typedefs)
                if (!string.IsNullOrEmpty(typedef.Name))
                    typedef.Name = "_" + typedef.Name;
            foreach (Event events in unit.Events)
                if (!string.IsNullOrEmpty(events.Name))
                    events.Name = "_" + events.Name;
        }

        return _hasParsingErrors ? throw new InvalidOperationException() : context;
    }

    private ASTContext ParseInternal(string[] sourceFiles)
    {
        ParserOptions parserOptions = new()
        {
            Verbose = true,
            ASTContext = new CppSharp.Parser.AST.ASTContext(),
            LanguageVersion = LanguageVersion.C99_GNU
        };

        parserOptions.SetupMSVC(VisualStudioVersion.VS2019);

        foreach (var includeDir in IncludeDirs)
            parserOptions.AddIncludeDirs(includeDir);

        foreach (var define in Defines)
            parserOptions.AddDefines(define);
        ParserResult result = ClangParser.ParseSourceFiles(sourceFiles, parserOptions);
        OnSourceFileParsed(sourceFiles, result);
        return ClangParser.ConvertASTContext(parserOptions.ASTContext);
    }

    private void OnSourceFileParsed(IEnumerable<string> files, ParserResult result)
    {
        switch (result.Kind)
        {
            case ParserResultKind.Success:
                Diagnostics.Message("Parsed '{0}'", string.Join(", ", files));
                break;
            case ParserResultKind.Error:
                Diagnostics.Error("Error parsing '{0}'", string.Join(", ", files));
                _hasParsingErrors = true;
                break;
            case ParserResultKind.FileNotFound:
                Diagnostics.Error("A file from '{0}' was not found", string.Join(",", files));
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        for (uint i = 0; i < result.DiagnosticsCount; ++i)
        {
            ParserDiagnostic diagnostics = result.GetDiagnostics(i);

            var message =
                $"{diagnostics.FileName}({diagnostics.LineNumber},{diagnostics.ColumnNumber}): {diagnostics.Level.ToString().ToLower()}: {diagnostics.Message}";
            Diagnostics.Message(message);
        }
    }
}
