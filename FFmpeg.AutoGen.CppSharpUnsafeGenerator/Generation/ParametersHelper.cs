using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using System.Linq;
using System.Text;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;

internal static class ParametersHelper
{
    public static string GetTypeName(TypeDefinition type, bool useLegacy) => useLegacy ? type.LegacyName ?? type.Name : type.Name;

    public static string GetParameters(FunctionParameter[] parameters, bool useLegacy, bool withAttributes = true)
    {
        return string.Join(", ", parameters.Select(GetParameter));

        string GetParameter(FunctionParameter parameter)
        {
            StringBuilder sb = new();
            if (withAttributes && parameter.Type.Attributes.Length > 0)
                _ = sb.Append($"{string.Join("", parameter.Type.Attributes)} ");
            if (parameter.IsConstant)
                _ = sb.Append("in ");
            if (parameter.ByReference)
                _ = sb.Append("ref ");
            _ = sb.Append($"{GetTypeName(parameter.Type, useLegacy)} @{parameter.Name}");
            return sb.ToString();
        }
    }


    public static string GetParameterNames(FunctionParameter[] parameters) => string.Join(", ",
            parameters.Select(x =>
            {
                StringBuilder sb = new();
                if (x.ByReference)
                    _ = sb.Append("ref ");
                _ = sb.Append($"@{x.Name}");
                return sb.ToString();
            }));
}
