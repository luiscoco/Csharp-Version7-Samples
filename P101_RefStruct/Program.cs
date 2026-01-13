// C# 7.2: ref struct (stack-only)
using System;
ref struct IntPair
{
    public int A;
    public int B;
    public int Sum => A + B;
}
class Program
{
    static void Main()
    {
        // Ref structs cannot be boxed, captured, in arrays, or as fields of classes
        IntPair p = new IntPair{ A=2, B=3 };
        Console.WriteLine(p.Sum);
    }
}
