// C# 7.0: out var; discards
using System;
class Program
{
    static void Main()
    {
        if (int.TryParse("123", out var value))
            Console.WriteLine($"Parsed: {value}");
        else
            Console.WriteLine("Failed");

        // Discard with out
        if (!int.TryParse("oops", out _))
            Console.WriteLine("Discarded out var on failure");

        // Discard in deconstruction later
        var (sum, _) = SumAndProduct(3, 4);
        Console.WriteLine($"Sum only: {sum}");
    }

    static (int sum, int product) SumAndProduct(int a, int b) => (a + b, a * b);
}
