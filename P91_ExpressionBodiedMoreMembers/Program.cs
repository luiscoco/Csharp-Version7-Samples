// C# 7.0: expression-bodied constructors, finalizers, accessors, indexers
using System;
class Sample
{
    private int _x;
    public Sample(int x) => _x = x;              // ctor
    ~Sample() => Console.WriteLine("finalized"); // finalizer
    public int X { get => _x; set => _x = value; } // accessors
    public int this[int i] { get => _x + i; }      // indexer
    public override string ToString() => $"X={_x}";
}
class Program
{
    static void Main()
    {
        var s = new Sample(5);
        Console.WriteLine(s);
        Console.WriteLine(s[3]);
    }
}
