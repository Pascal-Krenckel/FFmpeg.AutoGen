using CppSharp.AST;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Type = CppSharp.AST.Type;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processing;

internal class FunctionProcessor
{
    private const string ReturnMarshalAsConstCharPtr = "[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]";

    private const string ReturnMarshalAsLPUTF8Str = "[return: MarshalAs(UnmanagedType.LPUTF8Str)]";

    private const string MarshalAsUTF8Macros =
        "    \r\n" +
        "    #if NETSTANDARD2_1_OR_GREATER\r\n" +
        "    [MarshalAs(UnmanagedType.LPUTF8Str)]\r\n" +
        "    #else\r\n" +
        "    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]\r\n" +
        "    #endif\r\n" +
        "   ";

    private const string MarshalAsLPUTF8Str = "[MarshalAs(UnmanagedType.LPUTF8Str)]";


    private readonly ProcessingContext _context;

    public FunctionProcessor(ProcessingContext context) => _context = context;

    public StructureProcessor StructureProcessor { get; set; }

    public void Process(TranslationUnit translationUnit)
    {
        foreach (Function function in translationUnit.Functions)
        {
            string functionName = function.Name;

            void PopulateCommon(FunctionDefinitionBase inline)
            {
                inline.Name = functionName;
                inline.ReturnType = GetReturnType(function.ReturnType.Type, functionName);
                inline.Content = function.Comment?.BriefText;
                inline.ReturnComment = GetReturnComment(function);
                inline.Parameters = function.Parameters.Select((x, i) => GetParameter(function, x, i)).ToArray();
                inline.Obsoletion = ObsoletionHelper.CreateObsoletion(function);
            }

            if (function.IsInline)
            {
                var inlineDefinition = new InlineFunctionDefinition
                {
                    Body = function.Body,
                    OriginalBodyHash = GetSha256(function.Body)
                };
                PopulateCommon(inlineDefinition);
                _context.AddDefinition(inlineDefinition);
                continue;
            }

            if (!_context.FunctionExportMap.TryGetValue(functionName, out FunctionExport export))
            {
                Console.WriteLine($"Export not found. Skipping {functionName} function.");
                continue;
            }

            var exportDefinition = new ExportFunctionDefinition
            {
                LibraryName = export.LibraryName,
                LibraryVersion = export.LibraryVersion
            };
            PopulateCommon(exportDefinition);
            _context.AddDefinition(exportDefinition);
        }
    }

    internal TypeDefinition GetDelegateType(FunctionType functionType, string name)
    {
        var @delegate = new DelegateDefinition
        {
            Name = $"{name}_func",
            FunctionName = name,
            ReturnType = GetDelegateReturnType(functionType.ReturnType.Type, name),
            Parameters = functionType.Parameters.Select(GetParameter).ToArray()
        };
        _context.AddDefinition(@delegate);

        return @delegate;
    }

    private TypeDefinition GetDelegateReturnType(Type type, string name) =>
        // For delegates (function pointers), const char* must be byte* not string,
        // because string marshaling does not work with unmanaged function pointers.
        type is PointerType pointerType &&
            pointerType.QualifiedPointee.Qualifiers.IsConst &&
            pointerType.Pointee is BuiltinType builtinType &&
            builtinType.Type == PrimitiveType.Char
            ? new TypeDefinition { Name = "byte*" }
            : GetReturnType(type, name);

    private FunctionParameter GetParameter(Parameter parameter, int position)
    {
        string name = string.IsNullOrEmpty(parameter.Name) ? $"p{position}" : parameter.Name;
        TypeDefinition parameterType = GetParameterType(parameter.Type, name);
        return new FunctionParameter
        {
            Name = name,
            Type = parameterType,
            IsConstant = ParameterIsConstantFixedArray(parameter),
            IsIndirect = parameter.IsIndirect,
            ByReference = !parameter.IsConst && (parameterType.ByReference || parameterType is FixedArrayDefinition)
        };
    }

    private FunctionParameter GetParameter(Function function, Parameter parameter, int position)
    {
        string name = string.IsNullOrEmpty(parameter.Name) ? $"p{position}" : parameter.Name;
        TypeDefinition parameterType = GetParameterType(parameter.Type, $"{function.Name}_{name}");
        return new FunctionParameter
        {
            Name = name,
            Type = parameterType,
            Content = GetParamComment(function, parameter.Name),
            IsConstant = ParameterIsConstantFixedArray(parameter),
            IsIndirect = parameter.IsIndirect,
            ByReference = !parameter.IsConst && (parameterType.ByReference || parameterType is FixedArrayDefinition)
        };
    }

    private TypeDefinition GetParameterType(Type type, string name) => type is PointerType pointerType &&
            pointerType.QualifiedPointee.Qualifiers.IsConst &&
            pointerType.Pointee is BuiltinType builtinType
            ? builtinType.Type switch
            {
                PrimitiveType.Char => new TypeDefinition
                {
                    Name = "string",
                    Attributes = new[] { _context.NoCustomStringMarshal ? MarshalAsLPUTF8Str : MarshalAsUTF8Macros }
                },
                PrimitiveType.Void => new TypeDefinition
                {
                    Name = "void*"
                },
                _ => new TypeDefinition
                {
                    Name = TypeHelper.GetTypeName(type)
                }
            }
            : GetNoneBuiltinParameterType(type, name);

    private TypeDefinition GetReturnType(Type type, string name) => type is PointerType pointerType &&
            pointerType.QualifiedPointee.Qualifiers.IsConst &&
            pointerType.Pointee is BuiltinType builtinType
            ? builtinType.Type switch
            {
                PrimitiveType.Char => new TypeDefinition
                {
                    Name = "string",
                    Attributes = new[] { _context.NoCustomStringMarshal ? ReturnMarshalAsLPUTF8Str : ReturnMarshalAsConstCharPtr }
                },
                PrimitiveType.Void => new TypeDefinition
                {
                    Name = "void*"
                },
                _ => new TypeDefinition
                {
                    Name = TypeHelper.GetTypeName(type)
                }
            }
            : GetNoneBuiltinParameterType(type, name);

    private TypeDefinition GetNoneBuiltinParameterType(Type type, string name) =>
        // edge case when type is array of pointers to none builtin type (type[]* -> type**)
        type is ArrayType arrayType &&
            arrayType.SizeType == ArrayType.ArraySize.Incomplete &&
            arrayType.Type is PointerType arrayPointerType &&
            !(arrayPointerType.Pointee is BuiltinType || (arrayPointerType.Pointee is TypedefType typedefType &&
                                                          typedefType.Declaration.Type is BuiltinType))
            ? new TypeDefinition { Name = $"{TypeHelper.GetTypeName(arrayPointerType)}*" }
            : StructureProcessor.GetTypeDefinition(type, name);

    private static string GetParamComment(Function function, string parameterName)
    {
        ParamCommandComment comment = function?.Comment?.FullComment.Blocks
            .OfType<ParamCommandComment>()
            .FirstOrDefault(x => x.Arguments.Count == 1 && x.Arguments[0].Text == parameterName);
        return GetCommentString(comment);
    }

    private string GetReturnComment(Function function)
    {
        BlockCommandComment comment = function?.Comment?.FullComment.Blocks
            .OfType<BlockCommandComment>()
            .FirstOrDefault(x => x.CommandKind == CommentCommandKind.Return);
        return GetCommentString(comment);
    }

    private static bool ParameterIsConstantFixedArray(Parameter parameter) => parameter.IsConst && parameter.Type is ArrayType { SizeType: ArrayType.ArraySize.Constant };

    private static string GetCommentString(BlockCommandComment comment) => comment == null
            ? null
            : string.Join(" ", comment.ParagraphComment.Content.OfType<TextComment>().Select(x => x.Text.Trim()).Where(x => !string.IsNullOrWhiteSpace(x)));

    private static string GetSha256(string text)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(text);
        var sha256 = SHA256.Create();
        byte[] hash = sha256.ComputeHash(bytes);
        return Convert.ToBase64String(hash);
    }
}
