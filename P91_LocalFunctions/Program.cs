// C# 7.0: local functions
using System;
class Program
{
    static void Main()
    {
        int Fib(int n)
        {
            if (n <= 1) return n;
            return Fib(n - 1) + Fib(n - 2);
        }
        Console.WriteLine(Fib(8));
    }
}
