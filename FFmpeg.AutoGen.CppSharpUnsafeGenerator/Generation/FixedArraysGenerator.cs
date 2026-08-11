using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using System.Collections.Generic;
using System.Linq;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;

internal sealed class FixedArraysGenerator : GeneratorBase<FixedArrayDefinition>
{
    public FixedArraysGenerator(string path, GenerationContext context) : base(path, context)
    {
    }

    public static void Generate(string path, GenerationContext context)
    {
        using FixedArraysGenerator g = new(path, context);
        g.Generate();
    }

    public override IEnumerable<string> Usings()
    {
        yield return "System";
        yield return "System.ComponentModel";
        yield return "System.Runtime.CompilerServices";
        yield return "System.Runtime.InteropServices";
    }

    protected override IEnumerable<FixedArrayDefinition> Query(IEnumerable<FixedArrayDefinition> arrays) =>
        arrays.OrderBy(a => a.Length).ThenBy(a => a.Name);

    protected override void GenerateDefinition(FixedArrayDefinition array)
    {
        bool useLegacy = Context.IsLegacyGenerationOn;
        int length = array.Length;
        var elementType = array.ElementType;
        string elementTypeName = ParametersHelper.GetTypeName(elementType, useLegacy);
        string nonPtrElementTypeName = elementTypeName.Replace("*", "");
        string arrayName = useLegacy ? array.LegacyName : array.Name;
        string interfaceName = array.IsPointer ? nonPtrElementTypeName == "void" ?
            "IFixedPtrArray" :
            $"IFixedPtrArray<{nonPtrElementTypeName}>" :
            $"IFixedArray<{elementTypeName}>";
        WriteLine("[StructLayout(LayoutKind.Sequential)]");
        WriteLine($"public unsafe struct {arrayName} : {interfaceName}");

        using (BeginBlock())
        {
            string lengthPropertyName = useLegacy ? "Size" : "ArrayLength";
            WriteLine($"public static readonly int {lengthPropertyName} = {length};");
            WriteLine($"public readonly int Length => {length};");

            if (array.IsPrimitive)
                WritePrimitiveFixedArray(elementTypeName, length);
            else if (array.IsPointer)
            {
                if (nonPtrElementTypeName == "void")
                    WriteVoidPointerType(length, false);
                else
                    WritePointerType(elementTypeName, length);

            }
            else
                WriteComplexFixedArray(elementTypeName, length);

            if (!array.IsPointer)
            {               
                WriteLine($"public static implicit operator Span<{elementTypeName}>({arrayName} array) => array.AsSpan();");
                WriteLine($"public static implicit operator ReadOnlySpan<{elementTypeName}>({arrayName} array) => array.AsReadOnlySpan();");
            }
            else
            {
                WriteLine($"public static implicit operator Span<IntPtr>({arrayName} array) => array.AsSpan();");
                WriteLine($"public static implicit operator ReadOnlySpan<IntPtr>({arrayName} array) => array.AsReadOnlySpan();");
            }

            WriteLine("private static void CheckIndex(int index)");
            using (BeginBlock())
            {
                WriteLine($"if ((uint)index >= {length}) throw new ArgumentOutOfRangeException();");
            }

            WriteLine("private static void CheckIndex(uint index)");
            using (BeginBlock())
            {
                WriteLine($"if (index >= {length}) throw new ArgumentOutOfRangeException();");
            }
        }

        WriteLine();
    }

    private void WritePrimitiveFixedArray(string elementType, int length)
    {
        WriteLine($"fixed {elementType} _[{length}];");
        WriteLine();

        WriteLine($"public ref {elementType} this[int i] => ref _[i];");
        WriteLine($"public ref {elementType} this[uint i] => ref _[(int)i];");


        WriteLine($"public {elementType}[] ToArray()");
        using (BeginBlock())
            WriteLine($"var a = new {elementType}[{length}]; for (int i = 0; i < {length}; i++) a[i] = _[i]; return a;");

        WriteLine($"public void UpdateFrom({elementType}[] array)");
        using (BeginBlock())
        {
            WriteLine($"int length = Math.Min(array.Length, {length});");
            WriteLine($"for(int i = 0; i < length; i++) _[i] = array[i];");
        }
        WriteLine("[EditorBrowsable(EditorBrowsableState.Never)]");
        WriteLine($"public ref {elementType} GetPinnableReference() => ref _[0];");

        WriteLine($"public Span<{elementType}> AsSpan() {{ fixed(void* ptr = _) return new Span<{elementType}>(ptr, {length}); }}");
        WriteLine($"public ReadOnlySpan<{elementType}> AsReadOnlySpan() {{ fixed(void* ptr = _) return new ReadOnlySpan<{elementType}>(ptr, {length}); }}");
    }

    private void WriteComplexFixedArray(string elementType, int length)
    {
        WriteLine("#pragma warning disable CS9084");

        WriteLine($"{elementType} " + string.Join(",", Enumerable.Range(0, length).Select(i => $"_{i}")) + ";");
        WriteLine();

        WriteLine($"public ref {elementType} this[int i] ");
        using (BeginBlock())
        {
            WriteLine($"get {{ CheckIndex(i); return ref Unsafe.Add(ref _0, i); }}");
        }

        WriteLine($"public ref {elementType} this[uint i] ");
        using (BeginBlock())
        {
            WriteLine($"get {{  CheckIndex(i); return ref Unsafe.Add(ref _0, i); }}");
        }

        WriteLine($"public {elementType}[] ToArray()");
        using (BeginBlock())
        {
            WriteLine($"var a = new {elementType}[{length}];");
            WriteLine($"for (int i = 0; i < {length}; i++) a[i] = this[i];");
            WriteLine($"return a;");
        }

        WriteLine($"public void UpdateFrom({elementType}[] array)");
        using (BeginBlock())
        {
            WriteLine($"int length = Math.Min(array.Length, Length);");
            WriteLine($"for(int i = 0; i < length; i++) this[i] = array[i];");
        }
        
        WriteLine("[EditorBrowsable(EditorBrowsableState.Never)]");
        WriteLine($"public ref {elementType} GetPinnableReference() => ref _0;");


        WriteLine("#pragma warning restore CS9084");

        WriteLine($"public Span<{elementType}> AsSpan() {{ fixed(void* ptr = &_0) return new Span<{elementType}>(ptr, {length}); }}");
        WriteLine($"public ReadOnlySpan<{elementType}> AsReadOnlySpan() {{ fixed(void* ptr = &_0) return new ReadOnlySpan<{elementType}>(ptr, {length}); }}");
    }

    

    private void WriteVoidPointerType(int length, bool explicitInterface)
    {
        WriteLine("#pragma warning disable CS9084");

        if (!explicitInterface)
            WriteLine($"void* " + string.Join(",", Enumerable.Range(0, length).Select(i => $"_{i}")) + ";");
        WriteLine();
        string accessModifier = explicitInterface ? "" : "public";
        string interfacePrefix = explicitInterface ? "IFixedPtrArray." : "";
        WriteLine($"{accessModifier} void* {interfacePrefix}this[int i] ");
        using (BeginBlock())
        {
            WriteLine($"readonly get {{ CheckIndex(i); fixed(void* ptr = &_0) return *((void**)ptr + i); }}");
            WriteLine($"set {{ CheckIndex(i); fixed(void* ptr = &_0) *((void**)ptr + i) = value; }}");
        }

        WriteLine($"{accessModifier} void* {interfacePrefix}this[uint i] ");
        using (BeginBlock())
        {
            WriteLine($"readonly get {{ CheckIndex(i); fixed(void* ptr = &_0) return *((void**)ptr + i); }}");
            WriteLine($"set {{ CheckIndex(i); fixed(void* ptr = &_0) *((void**)ptr + i) = value; }}");
        }

        WriteLine($"{accessModifier} readonly void*[] {interfacePrefix}ToArray()");
        using (BeginBlock())
        {
            WriteLine($"var a = new void*[{length}];");
            WriteLine($"for (int i = 0; i < {length}; i++) a[i] = this[i];");
            WriteLine($"return a;");
        }

        WriteLine($"{accessModifier} void {interfacePrefix}UpdateFrom(void*[] array)");
        using (BeginBlock())
        {
            WriteLine($"int length = Math.Min(array.Length, Length);");
            if (!explicitInterface)
                WriteLine($"for(int i = 0; i < length; i++) this[i] = array[i];");
            else
                WriteLine($"for(int i = 0; i < length; i++) ((IFixedPtrArray)this)[i] = array[i];");

        }
        WriteLine("[EditorBrowsable(EditorBrowsableState.Never)]");
        if (!explicitInterface)
            WriteLine($"public ref void* GetPinnableReference() => ref _0;");
        else
            WriteLine($"ref void* IFixedPtrArray.GetPinnableReference() => throw new InvalidOperationException(\"This method should not be called with boxed type.\");");

        WriteLine($"public Span<IntPtr> AsSpan() {{ fixed(void* ptr = &_0) return new Span<IntPtr>(ptr, {length}); }}");
        WriteLine($"public ReadOnlySpan<IntPtr> AsReadOnlySpan() {{ fixed(void* ptr = &_0) return new ReadOnlySpan<IntPtr>(ptr, {length}); }}");

        WriteLine("#pragma warning restore CS9084");
    }

    private void WritePointerType(string elementType, int length)
    {
        WriteVoidPointerType(length, true);
        WriteLine("#pragma warning disable CS9084");
        WriteLine($"{elementType} " + string.Join(",", Enumerable.Range(0, length).Select(i => $"_{i}")) + ";");
        WriteLine();
        WriteLine($"public {elementType} this[int i] ");
        using (BeginBlock())
        {
            WriteLine($"readonly get {{ CheckIndex(i); fixed({elementType}* ptr = &_0) return *(ptr + i); }}");
            WriteLine($"set {{ CheckIndex(i); fixed({elementType}* ptr = &_0) *(ptr + i) = value; }}");
        }
        WriteLine($"public {elementType} this[uint i] ");
        using (BeginBlock())
        {
            WriteLine($"readonly get {{ CheckIndex(i); fixed({elementType}* ptr = &_0) return *(ptr + i); }}");
            WriteLine($"set {{ CheckIndex(i); fixed({elementType}* ptr = &_0) *(ptr + i) = value; }}");
        }
        WriteLine($"public readonly {elementType}[] ToArray()");
        using (BeginBlock())
        {
            WriteLine($"var a = new {elementType}[{length}];");
            WriteLine($"for (int i = 0; i < {length}; i++) a[i] = this[i];");
            WriteLine($"return a;");
        }
        WriteLine($"public void UpdateFrom({elementType}[] array)");
        using (BeginBlock())
        {
            WriteLine($"int length = Math.Min(array.Length, Length);");
            WriteLine($"for(int i = 0; i < length; i++) this[i] = array[i];");
        }
        WriteLine($"public ref {elementType} GetPinnableReference() => ref _0;");
        WriteLine("#pragma warning restore CS9084");

    }
}