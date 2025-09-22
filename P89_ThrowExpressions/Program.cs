// C# 7.0: throw expressions in null-coalescing / conditional
using System;
class Program
{
    static string Ensure(string s) => s ?? throw new ArgumentNullException(nameof(s));
    static void Main()
    {
        Console.WriteLine(Ensure("ok"));
        try { Console.WriteLine(Ensure(null)); }
        catch (Exception ex) { Console.WriteLine("Caught: " + ex.GetType().Name); }
    }
}
