# C# 7.0 - 7.2 Features – Sample Projects

This solution shows the biggest features introduced across **C# 7.0, 7.1, and 7.2**.  
Projects: `P84`–`P100`.

---

## 🧩 C# 7.0

### P88_OutVarAndDiscards
- **What’s new**: Declare `out var` inline; ignore values with `_`.
```csharp
if (int.TryParse(text, out var n))
    Console.WriteLine(n);

_ = int.TryParse(text, out _); // discard result and out value
```

### P89_TuplesDeconstruction
- **What’s new**: Lightweight tuples and deconstructing assignment.
```csharp
(int x, int y) p = (1, 2);
var (a, b) = p; // a=1, b=2
```

### P90_PatternMatching
- **What’s new**: `is` patterns and `switch` with `when` guards.
```csharp
object o = 42;
if (o is int i && i > 0) Console.WriteLine($"+{i}");
```

### P91_LocalFunctions
- **What’s new**: Define helper functions inside a method (supports recursion).
```csharp
int Fib(int n) => n <= 1 ? n : Add(Fib(n-1), Fib(n-2));
int Add(int a, int b) => a + b; // local
```

### P92_RefReturnsAndLocals
- **What’s new**: Return and store **references** to variables/elements.
```csharp
ref int Find(ref int a, ref int b) => ref (a > b ? ref a : ref b);
ref int best = ref Find(ref arr[0], ref arr[1]); best = 99;
```

### P93_ThrowExpressions
- **What’s new**: Use `throw` in expression contexts.
```csharp
string NameOrThrow(string? s) => s ?? throw new ArgumentNullException(nameof(s));
```

### P94_BinaryLiteralsDigitSeparators
- **What’s new**: `0b...` binary and `_` separators.
```csharp
int mask = 0b_1111_0000;
int large = 1_000_000;
```

### P95_ExpressionBodiedMoreMembers
- **What’s new**: Expression bodies for ctors, finalizers, accessors, indexers.
```csharp
class C
{
    public C(int x) => X = x;
    ~C() => Console.WriteLine("bye");
    public int X { get; private set; }
    public int this[int i] => i * 2;
}
```

---

## 🧩 C# 7.1

### 9) Async `Main` (`P92_AsyncMain`)
- **What’s new**: `static async Task Main()` entry point.
```csharp
static async Task Main()
{
    await Task.Delay(100);
    Console.WriteLine("done");
}
```

### 10) `default` literal (`P93_DefaultLiteral`)
- **What’s new**: Use `default` without a type.
```csharp
DateTime dt = default; // instead of default(DateTime)
```

### 11) Tuple element name inference (`P94_TupleNameInference`)
- **What’s new**: Names inferred from variable names.
```csharp
var x = 1; var y = 2;
var p = (x, y); // names inferred: p.x, p.y
```

---

## 🧩 C# 7.2

### 12) `in` parameters (`P95_InParameters`)
- **What’s new**: Pass by **readonly** reference.
```csharp
void Print(in BigStruct s) => Console.WriteLine(s.Value);
```

### 13) `ref readonly` returns (`P96_ReadonlyRefReturns`)
- **What’s new**: Return by ref but **read-only**.
```csharp
ref readonly int MaxRef(in int a, in int b) => ref (a > b ? ref a : ref b);
```

### 14) `ref struct` (stack-only types) (`P97_RefStruct`)
- **What’s new**: Types like `Span<T>`—cannot escape the stack.
```csharp
ref struct Window { public Span<int> Data; public Window(Span<int> s){ Data=s; } }
```

### 15) `private protected` (`P98_PrivateProtected`)
- **What’s new**: Accessible by derived types **in the same assembly**.
```csharp
class Base { private protected int X; }
```

### 16) Non-trailing named arguments (`P99_NonTrailingNamedArgs`)
- **What’s new**: Named args can appear before positional ones.
```csharp
Log(level: 2, "message", repeat: 3);
```

### 17) `stackalloc` to `Span<T>` (`P100_StackallocToSpan`)
- **What’s new**: Use `stackalloc` directly with spans and in more contexts.
```csharp
Span<int> s = stackalloc int[3] { 1, 2, 3 };
```

---

## ▶ How to build & run

From the repo root:
```bash
dotnet restore
dotnet build
dotnet run --project P84_OutVarAndDiscards
# …or any project (P85_…, P86_…, …)
```

