// Copyright 2020 Craytive Technologies BV. All rights reserved. Company proprietary and confidential.

using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator;

internal static class ExistingInlineFunctionsHelper
{
    private static readonly Regex FunctionNameRegex = new(
        @"\s+public static .+ (?<name>[\S]+)\(.*?\)",
        RegexOptions.Compiled | RegexOptions.Multiline);

    private static readonly Regex FunctionHashRegex = new(
        @"\s+// original body hash: (?<hash>\S+)",
        RegexOptions.Compiled | RegexOptions.Multiline);

    public static IEnumerable<InlineFunctionDefinition> LoadInlineFunctions(string path)
    {
        if (!File.Exists(path))
            yield break;

        string text = File.ReadAllText(path);

        MatchCollection nameMatches = FunctionNameRegex.Matches(text);
        MatchCollection hashMatches = FunctionHashRegex.Matches(text);

        Debug.Assert(nameMatches.Count == hashMatches.Count);

        for (int i = 0; i < nameMatches.Count; i++)
        {
            Match nameMatch = nameMatches[i];
            Match hashMatch = hashMatches[i];

            string name = nameMatch.Groups["name"].Value;
            string hash = hashMatch.Groups["hash"].Value;
            int bodyIndex = nameMatch.Index + nameMatch.Length;
            string body = text[bodyIndex..hashMatch.Index];

            var function = new InlineFunctionDefinition
            {
                Name = name,
                Body = body,
                OriginalBodyHash = hash
            };
            yield return function;
        }
    }
}
