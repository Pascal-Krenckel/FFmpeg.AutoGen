using CppSharp.AST;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using System.Collections.Generic;
using System.Linq;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processing;

internal static class ObsoletionHelper
{
    private static string GetMessage(Declaration declaration)
    {
        IEnumerable<string> lines = declaration.Comment?.FullComment?.Blocks
            .OfType<BlockCommandComment>()
            .Where(x => x.CommandKind == CommentCommandKind.Deprecated)
            .SelectMany(x =>
                x.ParagraphComment.Content.OfType<TextComment>().Select(c => c.Text.Trim())
            );
        string obsoleteMessage = lines == null ? string.Empty : string.Join(" ", lines);
        return obsoleteMessage;
    }

    public static Obsoletion CreateObsoletion(Declaration declaration)
    {
        string message = GetMessage(declaration);
        return new Obsoletion
        {
            IsObsolete = declaration.IsDeprecated || !string.IsNullOrWhiteSpace(message),
            Message = message
        };
    }
}
