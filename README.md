# C# 7.0, 7.1, 7.2 Features (VS 2017 era)

This solution demonstrates the **major features from C# 7.0, 7.1, and 7.2**.  
Language version is set to **7.2** so all samples compile in one solution; each project notes the version that introduced the feature.

## Projects
### C# 7.0
- **P84_OutVarAndDiscards** — `out var`, discards (`_`), tuple return.
- **P85_TuplesDeconstruction** — Tuples & deconstruction; named elements.
- **P86_PatternMatching** — `is` patterns and `switch` with `when` guards.
- **P87_LocalFunctions** — Local functions (with recursion).
- **P88_RefReturnsAndLocals** — `ref` returns & `ref` locals.
- **P89_ThrowExpressions** — `throw` in expressions (e.g., null-coalescing).
- **P90_BinaryLiteralsDigitSeparators** — `0b...` and `_` separators.
- **P91_ExpressionBodiedMoreMembers** — Expression-bodied ctor/finalizer/accessors/indexer.

### C# 7.1
- **P92_AsyncMain** — `async Task Main()` entry point.
- **P93_DefaultLiteral** — `default` literal.
- **P94_TupleNameInference** — Tuple element name inference.

### C# 7.2
- **P95_InParameters** — `in` parameters (readonly by ref).
- **P96_ReadonlyRefReturns** — `ref readonly` returns.
- **P97_RefStruct** — `ref struct` (stack-only types).
- **P98_PrivateProtected** — `private protected` access modifier.
- **P99_NonTrailingNamedArgs** — Named args not necessarily trailing.
- **P100_StackallocToSpan** — `stackalloc` in more contexts (assignment to `Span<T>`).

## Build & Run
```bash
dotnet restore
dotnet build
dotnet run --project P84_OutVarAndDiscards
```
Or try any project individually.

> Tip: For tuples, modern frameworks include `System.ValueTuple` by default; if you target older frameworks, add the NuGet package.
